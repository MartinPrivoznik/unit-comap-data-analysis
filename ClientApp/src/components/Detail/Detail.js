import React from "react";
import DataTable from "../DataTable/DataTable";
import "./Detail.css";

const fuck = "PASS";

const Detail = () => {
  return (
    <>
      <div className="row">
        <div className="col-md-6">
          <h4>IL4 PG24A</h4>
          <h2>S/N: 21510A00</h2>
        </div>
        <div className="col-md-6">
          <h1 className={fuck == "PASS" ? "greenTitle" : "redTitle"}>PASS</h1>
        </div>
      </div>
      <div className="row">
        <div className="col-md-4">
          <h4>Device</h4>
          <p>
            Name: ....
            <br />
            SF-CODE: ... <br />
            Family" .... <br />
          </p>
        </div>
        <div className="col-md-4">
          <h4>Test details</h4>
          <p>
            Test total time: ....
            <br />
            Tester: ... <br />
            ...." .... <br />
          </p>
        </div>
        <div className="col-md-4">
          <h4>Components</h4>
          <ul>
            <li>Jmeno - Verze</li>
            <li>Jmeno - Verze</li>
          </ul>
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
