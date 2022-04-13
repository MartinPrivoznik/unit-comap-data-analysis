import React from "react";

const SideBar = () => {
  return (
    <>
      <div className="vertical-menu">
        <div data-simplebar className="h-100">
          <div id="sidebar-menu">
            <ul className="metismenu list-unstyled" id="side-menu">
              <li className="menu-title">Main</li>

              <li>
                <a href="/product-list" className="waves-effect">
                  <i className="mdi mdi-view-dashboard"></i>
                  <span>Produkty</span>
                </a>
              </li>

              <li>
                <a href="/overview" className=" waves-effect">
                  <i className="mdi mdi-calendar-check"></i>
                  <span>Overview</span>
                </a>
              </li>

              <li>
                <a href="/detail" className=" waves-effect">
                  <i className="mdi mdi-calendar-check"></i>
                  <span>Detail</span>
                </a>
              </li>
            </ul>
          </div>
        </div>
      </div>
    </>
  );
};

export default SideBar;
