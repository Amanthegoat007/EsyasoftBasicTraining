import React, { useState } from "react";

const EventComponent = () => {
  const [hi, setHi] = useState("");
  const [name, setname] = useState("");
  function hii() {
    console.log("Hi");
    // return <p>Hi</p>;
    setHi((hi) => hi + " hi ^_^");
  }

  return (
    <div onMouseEnter={hii} style={{ background: "gray", margin: "2rem" }}>
      Welcome to Events
      <p>{hi}</p>
      <button onClick={hii}>hello</button>
      <p>{name} hello</p>
      <input
        onChange={(e) => {
          console.log(e);
          setTimeout(() => {
            setname(e.target.value);
          }, 1000);
        }}
        type="text"
        placeholder="enter something!"
      />
    </div>
  );
};

export default EventComponent;
