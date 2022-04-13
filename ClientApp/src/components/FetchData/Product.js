import React, { useEffect, useState } from "react";
import { getProduct } from "../../actions/actions";

export default function Product() {
  const [dataApi, setData] = useState(null);

  useEffect(() => {
    const getData = async () => {
      const data = await getProduct();
      setData(data);
    };

    getData();
  }, []);

  const contents = !dataApi ? (
    <p>
      <em>Loading...</em>
    </p>
  ) : (
    <table className="table table-striped" aria-labelledby="tabelLabel">
      <thead>
        <tr>
          <th>ID</th>
          <th>State</th>
          <th>Name</th>
          <th></th>
        </tr>
      </thead>
      <tbody>
        {dataApi.map((product) => (
          <tr key={product.id}>
            <td>{product.id}</td>
            <td>{product.state/*??*/}</td>
            <td>{product.name}</td>
            <td>{product.asinecovic}</td>
          </tr>
        ))}
      </tbody>
    </table>
  );

  return (
    <div>
      <h1 id="tabelLabel">Product</h1>
      <p>This component demonstrates fetching data from the server.</p>
      {contents}
    </div>
  );
}
