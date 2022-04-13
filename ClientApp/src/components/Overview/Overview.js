import React, { useState } from "react";
import DatePicker from "react-datepicker";
import C3Chart from "react-c3js";
import "./Overview.css";
import "c3/c3.css";

import "react-datepicker/dist/react-datepicker.css";

const Overview = () => {
  const [startDate, setStartDate] = useState(new Date());
  const [endDate, setEndDate] = useState(new Date());
  const onChange = (dates) => {
    const [start, end] = dates;
    setStartDate(start);
    setEndDate(end);
  };
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
  return (
    <>
      <div className="row">
        <h1>IL4 PG24A</h1>
      </div>
      <div>
        <h2>{`Chybovost produktu v datovém okně ${
          startDate == null ? "" : startDate.toLocaleDateString()
        } - ${endDate == null ? "" : endDate.toLocaleDateString()}`}</h2>
        <div>
          <div>
            <C3Chart data={data} color={color} />
          </div>
          <div>
            <DatePicker
              selected={startDate}
              onChange={onChange}
              startDate={startDate}
              endDate={endDate}
              selectsRange
              inline
            />
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
