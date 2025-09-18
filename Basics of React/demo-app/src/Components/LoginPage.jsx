import React from "react";
import { useState } from "react";
const LoginPage = () => {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const onLoginHandler = () => {
    if(username!=='username'){
        alert("Invalid UserName!!");
        return;
    }
    if(password!='password'){
        alert("Invalid Password");
        return ;
    }
     alert("Login Successful!");
  };
  return (
    <form onSubmit={onLoginHandler}>
      <input
        onChange={(e) => setUsername(e.target.value)}
        type="text"
        placeholder="Enter Your Username"
        value={username}
      />
      <input
        onChange={(e) => setPassword(e.target.value)}
        type="password"
        placeholder="Enter Your Password"
        value={password}
      />
      <button  type="submit">Login</button>
        {/* <button type="submit">Login</button> */}
      <div style={{padding:'1rem'}}>
        <p>Username: {username}</p>
        <p>Password: {password}</p>
      </div>
    </form>
  );
};

export default LoginPage;
