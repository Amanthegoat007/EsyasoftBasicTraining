import { createContext, useContext, useState } from "react";
import reactLogo from "./assets/react.svg";
import viteLogo from "/vite.svg";
import "./App.css";
import UseContextComponent from "./Component/UseContextComponent";
import UseReducerComponent from "./Component/UseReducerComponent";
import CallAnApiComponent from "./Component/CallAnApiComponent";

const Context = createContext(null);
export { Context };
function App() {
  const [count, setCount] = useState(0);
  const [theme, setTheme] = useState("light");
  return (
    <Context.Provider value={{ theme: theme, setTheme: setTheme }}>
      <UseContextComponent />
      <UseReducerComponent />
      <CallAnApiComponent/>
    </Context.Provider>
  );
}

export default App;
