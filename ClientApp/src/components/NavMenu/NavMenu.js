import React, { useState } from "react";
import {
  Collapse,
  Container,
  Navbar,
  NavbarBrand,
  NavbarToggler,
  NavItem,
  NavLink,
} from "reactstrap";
import { Link } from "react-router-dom";
import "./NavMenu.css";

export default function NavMenu() {
  const [collapsed, setCollapsed] = useState(false);

  const toggleNavbar = () => {
    setCollapsed(!collapsed);
  };

  return (
    <header id="page-topbar">
      <div className="navbar-header">
        <div className="d-flex">
          <div className="navbar-brand-box">
            <a href="/" className="logo logo-dark">
              <span className="logo-sm">
                <img src="images/logoComApp.png" alt="" height="22" />
              </span>
              <span className="logo-lg">
                <img src="images/logoComApp.png" alt="" height="38" />
              </span>
            </a>

            <a href="/" className="logo logo-light">
              <span className="logo-sm">
                <img src="images/logoComApp.png" alt="" height="22" />
              </span>
              <span className="logo-lg">
                <img src="images/logoComApp.png" alt="" height="18" />
              </span>
            </a>
          </div>
        </div>
      </div>
    </header>
  );
}
