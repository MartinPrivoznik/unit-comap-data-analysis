import React, { useEffect, useState } from "react";
import { getProductNames } from "../../actions/actions";

export default function Products() {
    const [dataApi, setData] = useState(null);

    useEffect(() => {
        const getData = async () => {
            const data = await getProductNames();
            setData(data);
        };

        getData();
    }, []);

    const contents = !dataApi ? (
        <p>
            <em>Loading...</em>
        </p>
    ) : (
        <div className="tableDiv">
            {console.log(dataApi)}
            <table className="table table-striped" aria-labelledby="tabelLabel" >
                <thead>
                    <tr>
                        {Object.keys(dataApi[0]).map((e) => (
                            <th>{e}</th>
                        ))}
                    </tr>
                </thead>
                <tbody>
                    {dataApi.map((product) => (
                        <tr key={product.id}>
                            <td>{product.id}</td>
                            <td>{product.productName}</td>
                            <td>{product.productSN}</td>
                            <td>{product.success ? "PASS" : "FAILED"}</td>
                            <td>{product.dateSOfTesting}</td>
                            <td>{product.testTime}</td>
                            <td>{product.testerInfo}</td>
                            <td>{product.userName}</td>
                            <td>{product.iniSecurity}</td>
                            <td>testGroups :D</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );

    return (
        <div>
            <h1 id="tabelLabel">Products</h1>
            <p>This component demonstrates fetching data from the server.</p>
            {contents}
        </div>
    );
}
