import React from "react";
import { Route } from "react-router";
import Layout from "./Layout";
import Home from "./Home";
import Overview from "./Overview/Overview";
import ProductList from "./ProductList/ProductList";
import Detail from "./Detail/Detail";
import "./App.css";
import Products from "./FetchData/Products";

const App = () => {
  return (
    <Layout>
      <Route exact path="/" component={Home} />
      <Route path="/products" component={Products} />
      <Route exact path="/overview" component={Home} />
      <Route exact path="/overview/:id?" component={Overview} />
      <Route path="/product-list" component={ProductList} />
      <Route path="/detail/:id?" component={Detail} />
    </Layout>
  );
};

export default App;
