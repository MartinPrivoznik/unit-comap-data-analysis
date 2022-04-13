import React, { useState } from "react";
import { addDays } from "date-fns";
import { DateRangePicker } from "react-date-range";
import C3Chart from "react-c3js";
import "./Overview.css";
import "c3/c3.css";

import "react-date-range/dist/styles.css"; // main css file
import "react-date-range/dist/theme/default.css"; // theme css file

const Overview = () => {
  const data = {
    columns: [
      ["PASS", 382],
      ["FAIL", 22],
    ],
    type: "donut",
  };
  const color = {
    pattern: ["#58db83", "#d95a6f"],
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
        <h1>IL4 PG24A</h1>
      </div>
      <div>
        <h2>{`Chybovost produktu v datovém okně ${
          date.startDate == null ? "" : date.startDate.toLocaleDateString()
        } - ${
          date.endDate == null ? "" : date.endDate.toLocaleDateString()
        }`}</h2>
        <div>
          <div>
            <C3Chart data={data} color={color} />
          </div>
          <div>
            <DateRangePicker
              onChange={(item) => setDate([item.selection])}
              showSelectionPreview={true}
              moveRangeOnFirstSelection={false}
              months={1}
              ranges={date}
              direction="horizontal"
            />
            ;
          </div>
        </div>
      </div>
      <div className="row">
        <div className="col-xl-3 col-sm-6">
          <div className="card mini-stat bg-primary">
            <div className="card-body mini-stat-img">
              <div className="mini-stat-icon">
                <i className="mdi mdi-cube-outline float-end"></i>
              </div>
              <div className="text-white">
                <h6 className="text-uppercase mb-3 font-size-16 text-white">
                  Orders
                </h6>
                <h2 className="mb-4 text-white">1,587</h2>
                <span className="badge bg-info"> +11% </span>{" "}
                <span className="ms-2">From previous period</span>
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default Overview;
