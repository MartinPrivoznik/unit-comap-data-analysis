import React, { useEffect, useState } from "react";
import { getLastTestsBySn } from "../../actions/actions";
import "./DataTable.css";

const phrase = "PASS";

const DataTable = (dataApi) => {
  return (
    <>
      <div className="row">
        <div className="col-12">
          <div className="card">
            <div className="card-body">
              <h4 className="card-title">Provedené testy</h4>
              <p className="card-title-desc">
                Seznam všech reportů k tomuto produktu.
              </p>

              <table
                id="datatable-buttons"
                className="table table-striped table-bordered dt-responsive nowrap"
                style={{
                  borderCollapse: "collapse",
                  borderSpacing: "0",
                  width: "100%",
                }}
              >
                <thead>
                  <tr>
                    {Object.keys(dataApi.dataApi[0]).map((e) => (
                      e == "testGroups" ? null : <th key={e} >{e}</th>
                    ))}
                  </tr>
                </thead>
                <tbody>
                  {dataApi.dataApi.map((product) => (
                    <tr key={product.id}>
                      <td>{product.id}</td>
                      <td>{product.productName}</td>
                      <td>{product.productSN}</td>
                      <td>
                        <span
                          className={product.success ? "bgGreen" : "bgRed"}
                        ></span>
                      </td>
                      <td>{product.dateSOfTesting}</td>
                      <td>{product.testTime}</td>
                      <td>{product.testerInfo}</td>
                      <td>{product.userName}</td>
                      <td>{product.iniSecurity}</td>
                    </tr>
                  ))}
                </tbody>
              </table>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default DataTable;
