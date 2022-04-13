import React from "react";
import "./DataTable2.css";

const fuck = "PASS";

const DataTable2 = () => {
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
                    <th>S/N</th>
                    <th>Doba trvání</th>
                    <th>Název testovací aplikace</th>
                    <th>Verze aplikace</th>
                    <th>Uživatel</th>
                    <th>Timestemp</th>
                    <th>INIS</th>
                    <th>Výsledek testu</th>
                  </tr>
                </thead>

                <tbody>
                  <tr>
                    <td>21510A00</td>
                    <td>420 s</td>
                    <td>UniTesterApp</td>
                    <td>1.0.0.20</td>
                    <td>9</td>
                    <td>21. 6. 2020 8:00</td>
                    <td>ISISIIIS</td>
                    <td>
                      PASS{" "}
                      <span
                        className={fuck == "PASS" ? "bgGreen" : "bgRed"}
                      ></span>
                    </td>
                  </tr>
                </tbody>
              </table>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default DataTable2;
