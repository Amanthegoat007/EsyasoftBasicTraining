import React, { useState, useEffect } from "react";

const LoginForm = () => {
  const suggestionData = ["laptop", "mobile", "phone", "mango", "modi", "lapu"];
  const [search, setSearch] = useState("");

  const [recomendation, setRecomendation] = useState(suggestionData);

  useEffect(() => {
    setRecomendation(suggestionData.filter((elem) => elem.includes(search)));
    console.log("UseEffect is triggered");
  }, [search]);
  const [loginState, setLoginState] = useState({
    username: "",
    password: "",
  });

  const onUsernameChangeHandler = (e) => {
    setLoginState({ ...loginState, username: e.target.value });
  };

  const onPasswordChangeHandler = (e) => {
    setLoginState({ ...loginState, password: e.target.value });
  };

  return (
    <div>
      <p>Welcome to Login Form</p>
      <form
        action="POST"
        onSubmit={(e) => {
          e.preventDefault();
          console.log(e);
          console.log("e.target--->", e.target[0].name);
        }}
      >
        <input
          name="username"
          type="text"
          value={loginState.username}
          placeholder="Enter your Username"
          onChange={onUsernameChangeHandler}
        />
        <br />
        <input
          name="password"
          type="password"
          value={loginState.password}
          placeholder="Enter your Password"
          onChange={onPasswordChangeHandler}
        />
        <br />
        <button type="submit">Login</button>
      </form>
      <div>
        <input
          type="text"
          value={search}
          onChange={(e) => setSearch(e.target.value)}
        />
        {recomendation.map((element) => (
          <div> {element} </div>
        ))}
      </div>
    </div>
  );
};

export default LoginForm;
