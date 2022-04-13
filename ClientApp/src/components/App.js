import React from "react";
import { Route } from "react-router";
import Layout from "./Layout";
import Home from "./Home";
import FetchData from "./FetchData/FetchData";
import Overview from "./Overview/Overview";
import "./App.css";

const App = () => {
  return (
    <Layout>
      <Route exact path="/" component={Home} />
      <Route path="/fetch-data" component={FetchData} />
      <Route path="/overview" component={Overview} />
    </Layout>
  );
};

export default App;
