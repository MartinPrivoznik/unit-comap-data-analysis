import React, { useState, useEffect } from "react";
import DataTable from "../DataTable/DataTable";
import "./Detail.css";

const Detail = (params) => {
  console.log(params);
  return (
    <>
      <div className="row">
        <div className="col-md-6">
          <h4>{params.productName}</h4>
          <h2>S/N: {params.productSn}</h2>
        </div>
        <div className="col-md-6">
          <h1 className={params.Success ? "greenTitle" : "redTitle"}>
            {params.Success ? "PASS" : "FAIL"}
          </h1>
        </div>
      </div>
      <div className="row">
        <div className="col-md-4">
          <h4>Device</h4>
          <p>
            Name: {params.productName}
            <br />
            SF-CODE: {params.productSn} <br />
          </p>
        </div>
        <div className="col-md-4">
          <h4>Test details</h4>
          <p>
            Test total time: {params.testTime}
            <br />
            Tester: {params.testerInfo} <br />
            <br />
          </p>
        </div>
      </div>
      <ul className="nav nav-pills nav-justified" role="tablist">
        <li className="nav-item waves-effect waves-light">
          <a
            className="nav-link active"
            data-bs-toggle="tab"
            href="#home-1"
            role="tab"
          >
            <span className="d-block d-sm-none">
              <i className="fas fa-home"></i>
            </span>
            <span className="d-none d-sm-block">21. 6. 2020 8:00</span>
          </a>
        </li>
      </ul>

      <div className="tab-content">
        <div className="tab-pane active p-3" id="home-1" role="tabpanel">
          <div className="row">
            <DataTable></DataTable>
          </div>
        </div>
      </div>
    </>
  );
};

export default Detail;
