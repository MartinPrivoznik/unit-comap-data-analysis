import React from 'react';
import { Route } from 'react-router';
import Layout from './Layout';
import Home from './Home';
import FetchData from './FetchData/FetchData';
import Overview from './Overview/Overview';
import ProductList from './ProductList/ProductList';
import './App.css';

const App = () => {
  return (
    <Layout>
      <Route exact path="/" component={Home} />
      <Route path="/fetch-data" component={FetchData} />
      <Route path="/overview" component={Overview} />
      <Route path="/product-list" component={ProductList} />
    </Layout>
  );
};

export default App;
