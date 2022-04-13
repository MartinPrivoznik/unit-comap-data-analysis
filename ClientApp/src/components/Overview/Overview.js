import React, { useState, useEffect } from "react";
import { addDays } from "date-fns";
import { DateRangePicker } from "react-date-range";
import C3Chart from "react-c3js";
import DataTable from "../DataTable/DataTable";
import "./Overview.css";
import "c3/c3.css";
import { getLastTestsBySn } from "../../actions/actions";

import "react-date-range/dist/styles.css"; // main css file
import "react-date-range/dist/theme/default.css"; // theme css file

const Overview = (sn) => {
  const [dataApi, setData] = useState(null);

  useEffect(() => {
    const getData = async () => {
      const data = await getLastTestsBySn("IL PG24A");
      setData(data);
    };

    getData();
  }, []);

  const passCount = dataApi ? dataApi.filter((data) => data.success).length : 0;
  const failCount = dataApi
    ? dataApi.filter((data) => !data.success).length
    : 0;

  const statsData = {
    columns: [
      ["PASS", passCount],
      ["FAIL", failCount],
    ],
    type: "donut",
  };
  const timeData = {
    columns: [
      ["IL PG24A", 7.6],
      ["IL PG24B", 9.4],
      ["IL PG24C", 6.9],
    ],
    type: "bar",
  };
  const donutColor = {
    pattern: ["#58db83", "#d95a6f"],
  };
  const timeColor = {
    pattern: [
      "#3d91ff",
      "#adadad",
      "#b7b7b7",
      "#c1c1c1",
      "#cccccc",
      "#d6d6d6",
      "#e0e0e0",
    ],
  };
  const [date, setDate] = useState([
    {
      startDate: new Date(),
      endDate: addDays(new Date(), -7),
      key: "selection",
    },
  ]);
  return (
    <>
      <div className="row">
        <div className="col-md-6">
          <h1>IL4 PG24A</h1>
          <h4>Vybere si časové okno, ze kterého chcete použít data</h4>
        </div>
        <div className="col-md-6">
          <div className="d-flex justify-content-center">
            <DateRangePicker
              onChange={(item) => setDate([item.selection])}
              showSelectionPreview={true}
              moveRangeOnFirstSelection={false}
              months={1}
              ranges={date}
              direction="horizontal"
            />
          </div>
        </div>
      </div>
      <div className="row">
        <div className="col-md-6">
          <div className="errorCard">
            <h2>Chybovost produktu</h2>
            <div>
              <C3Chart data={statsData} color={donutColor} />
            </div>
            <p>
              Vadných produktů: <b>{failCount}</b> <br />
              Bezchybných produktů: <b>{passCount}</b>{" "}
            </p>
          </div>
        </div>
        <div className="col-md-6">
          <div className="errorCard">
            <h2>Doba trvání testu</h2>
            <span>
              Průměrná doba testování je: <b>7.6 minut</b>
            </span>
            <h3 className="mt-4">Porovnání času testování</h3>
            <p>
              Porovnání průměrné doby testování produktu IL4 PG24A s dalšími
              produkty v nabídce.
            </p>
            <div className="row">
              <C3Chart data={timeData} color={timeColor} />
            </div>
          </div>
        </div>
      </div>
      <div className="row">
        <DataTable></DataTable>
      </div>
    </>
  );
};

export default Overview;
