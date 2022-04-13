import React, { useEffect, useState } from "react";
import { getWeatherInfo } from "../../actions/getWeatherInfo";

export default function FetchData() {
  const [weatherInfo, setWeatherInfo] = useState(null);

  useEffect(() => {
    const getData = async () => {
      const data = await getWeatherInfo();
      setWeatherInfo(data);
    };

    getData();
  }, []);

  const contents = !weatherInfo ? (
    <p>
      <em>Loading...</em>
    </p>
  ) : (
    <table className="table table-striped" aria-labelledby="tabelLabel">
      <thead>
        <tr>
          <th>Date</th>
          <th>Temp. (C)</th>
          <th>Temp. (F)</th>
          <th>Summary</th>
        </tr>
      </thead>
      <tbody>
        {weatherInfo.map((forecast) => (
          <tr key={forecast.date}>
            <td>{forecast.date}</td>
            <td>{forecast.temperatureC}</td>
            <td>{forecast.temperatureF}</td>
            <td>{forecast.summary}</td>
          </tr>
        ))}
      </tbody>
    </table>
  );

  return (
    <div>
      <h1 id="tabelLabel">Weather forecast</h1>
      <p>This component demonstrates fetching data from the server.</p>
      {contents}
    </div>
  );
}
