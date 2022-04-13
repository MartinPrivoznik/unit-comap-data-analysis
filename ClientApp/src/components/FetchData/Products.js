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
        <p> {console.log(dataApi)}</p>
    );

    return (
        <div>
            <h1 id="tabelLabel">Products</h1>
            <p>This component demonstrates fetching data from the server.</p>
            {contents}
        </div>
    );
}
