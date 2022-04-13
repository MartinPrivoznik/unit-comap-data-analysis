import React from 'react';

const ProductList = () => {
  const productNames = ['a', 'b'];
  const ProductCards = productNames.map((name) => (
    <a href="/overview" key={name}>
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
              <h2 className="mb-4 text-white">{name}</h2>
            </div>
          </div>
        </div>
      </div>
    </a>
  ));
  return (
    <>
      <div className="row">{ProductCards}</div>
    </>
  );
};

export default ProductList;
