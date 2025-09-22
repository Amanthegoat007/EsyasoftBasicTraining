import React, { useEffect } from "react";
import { useState } from "react";

const CallAnApiComponent = () => {
  const [data, setData] = useState([]);
  const getData = () => {
      fetch("https://jsonplaceholder.typicode.com/posts")
        .then((data) => data.json())
        .then((jsonData) => setData(jsonData))
  };
  useEffect(getData, []);
  return (
    <div>
      {/* {getData} */}
      {/* <button onClick={()=>setData(getData())}>Load Data</button> */}
      {data.map((element) => (
        <div key={element.id}>{element.title}</div>
      ))}
    </div>
  );
};

export default CallAnApiComponent;
