import React from 'react';
import { Route } from 'react-router';
import Layout from './Layout';
import Home from './Home';
import FetchData from './FetchData/FetchData';
import Overview from './Overview/Overview';
import ProductList from './ProductList/ProductList';
import Detail from './Detail/Detail';
import './App.css';

const App = () => {
  return (
    <Layout>
      <Route exact path="/" component={Home} />
      <Route path="/overview" component={Overview} />
      <Route path="/product-list" component={ProductList} />
      <Route path="/detail" component={Detail} />
    </Layout>
  );
};

export default App;
