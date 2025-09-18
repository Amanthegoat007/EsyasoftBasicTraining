import { useState } from "react";
import "./App.css";
import EventComponent from "./Components/EventComponent";
import LoginPage from "./Components/LoginPage";
import LoginForm from "./Components/LoginForm";

function App() {
  const [count, setCount] = useState(0);
  function increase() {
    setCount((count) => count + 1);
  }
  return (
    <>
      {/* <div
        style={{
          background: "brown",
          padding: "0.5rem",
          display: "flex",
          gap: "1rem",
        }}
      >
        <h1>{count}</h1>
        <button onClick={() => setCount((count) => count + 1)}>
          {" "}
          Increase {count}
        </button>
        <button onClick={() => setCount((count) => count - 1)}>
          {" "}
          Decrease {count}
        </button>
      </div>
      <EventComponent />

      <LoginPage /> */}
      <LoginForm/>
    </>
  );
}

export default App;
