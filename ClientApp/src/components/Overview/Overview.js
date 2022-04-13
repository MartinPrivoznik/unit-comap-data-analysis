import React, { useState } from 'react';
import { addDays } from 'date-fns';
import { DateRangePicker } from 'react-date-range';
import C3Chart from 'react-c3js';
import './Overview.css';
import 'c3/c3.css';

import 'react-date-range/dist/styles.css'; // main css file
import 'react-date-range/dist/theme/default.css'; // theme css file

const Overview = () => {
  const data = {
    columns: [
      ['PASS', 382],
      ['FAIL', 22],
    ],
    type: 'donut',
  };
  const color = {
    pattern: ['#58db83', '#d95a6f'],
  };
  const [date, setDate] = useState([
    {
      startDate: new Date(),
      endDate: addDays(new Date(), -7),
      key: 'selection',
    },
  ]);
  return (
    <>
      <div className="row">
        <h1>IL4 PG24A</h1>
      </div>
      <div className="row">
        <h2>Chybovost produktu</h2>
      </div>
      <div className="row">
        <div className="col-md-6">
          <div>
            <C3Chart data={data} color={color} />
          </div>
          <div>
            <DateRangePicker
              onChange={(item) => setDate([item.selection])}
              showSelectionPreview={true}
              moveRangeOnFirstSelection={false}
              months={1}
              ranges={date}
              direction="horizontal"
            />
            ;
          </div>
        </div>
      </div>
    </>
  );
};

export default Overview;
