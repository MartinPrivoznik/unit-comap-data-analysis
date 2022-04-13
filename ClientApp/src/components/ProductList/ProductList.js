import React, { useEffect, useState } from 'react';
import { getProductNames } from '../../actions/actions';

const ProductList = () => {
  const [dataApi, setData] = useState(null);

  useEffect(() => {
    const getData = async () => {
      const data = await getProductNames();
      setData(data);
    };

    getData();
  }, []);

  const ProductCards = !dataApi ? (
    <p>
      <em>Loading...</em>
      {/* Tady by to chtělo nějaký pěkný spinner :) https://www.w3schools.com/howto/howto_css_loader.asp */}
    </p>
  ) : (
    dataApi.map((el) => (
      <a href="/overview" key={el.name}>
        {console.log(dataApi)}
        <div className="col-xl-3 col-sm-6">
          <div className="card mini-stat bg-primary">
            <div className="card-body mini-stat-img">
              <div className="mini-stat-icon">
                <i className="mdi mdi-cube-outline float-end"></i>
              </div>
              <div className="text-white">
                <h6 className="text-uppercase mb-3 font-size-16 text-white">
                  Orders
                </h6>
                <h2 className="mb-4 text-white">{el.name}</h2>
              </div>
            </div>
          </div>
        </div>
      </a>
    ))
  );
  return (
    <>
      <div className="row">{ProductCards}</div>
    </>
  );
};

export default ProductList;
