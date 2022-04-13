import React, { useState, useEffect } from 'react';
import api from '../../api';

const Detail = () => {
  const [data, setData] = useState([]);
  api.get;
  return (
    <>
      <div className="row">
        <h1>IL4 PG24A</h1>
      </div>
      <div className="row">
        <h2>Chybovost produktu</h2>
      </div>
    </>
  );
};

export default Detail;
