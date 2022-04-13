import React from 'react';

const ProductList = () => {
  const productNames = ['a', 'b'];
  const ProductCards = productNames.map((name) => (
    <a href={`/${name}`} key={name}>
      <div>
        <h2>{name}</h2>
        <span>Detail</span>
      </div>
    </a>
  ));
  return <>{ProductCards}</>;
};

export default ProductList;
