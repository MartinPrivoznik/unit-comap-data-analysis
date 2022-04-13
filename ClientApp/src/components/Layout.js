import React, { Component } from "react";
import { Container } from "reactstrap";
import NavMenu from "./NavMenu/NavMenu";

import SideBar from "./SideBar/SideBar";
export default class Layout extends Component {
  static displayName = Layout.name;

  render() {
    return (
      <div>
        <NavMenu />
        <SideBar />
        <Container>{this.props.children}</Container>
      </div>
    );
  }
}
