import React from 'react';

const ProductList = () => {
  const productNames = ['a', 'b'];
  const ProductCards = productNames.map((name) => (
    <a href="/overview" key={name}>
      <div className="card mini-stat bg-primary">
        <div className="card-body mini-stat-img">
          <div className="mini-stat-icon">
            <i className="mdi mdi-cube-outline float-end"></i>
          </div>
          <div className="text-white">
            <h6 className="text-uppercase mb-3 font-size-16 text-white">
              {name}
            </h6>
            <h2 className="mb-4 text-white">Detail</h2>
            <span className="badge bg-info"> +11% </span>{' '}
            <span class="ms-2">From previous period</span>
          </div>
        </div>
      </div>
    </a>
  ));
  return <>{ProductCards}</>;
};

export default ProductList;
