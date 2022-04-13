import React from "react";
import DataTable from "../DataTable/DataTable";

const Detail = () => {
  return (
    <>
      <div className="row">
        <h1>IL4 PG24A</h1>
      </div>
      <div className="row">
        <h2>Chybovost produktu</h2>
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
            <span className="d-none d-sm-block">Home</span>
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
