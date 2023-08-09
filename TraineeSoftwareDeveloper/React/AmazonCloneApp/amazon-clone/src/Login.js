import React, { useState } from 'react';
import './Login.css';
import {Link, useNavigate} from "react-router-dom";
import {auth} from "./firebase.js";
import {createUserWithEmailAndPassword, signInWithEmailAndPassword} from "firebase/auth";

function Login() {
  const history = useNavigate();
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');

  const signIn = e => {
    e.preventDefault();    {/* prevent page from refreshing */}

    // Some fancy firebase LogIn
    signInWithEmailAndPassword(auth, email, password)
    .then((auth) => {
      if(auth){
        history('/');
      }
      // It successfully signin a user with email and password //test123temp123@gmail.com
      console.log(auth);
    })
    .catch(error => alert(error.message));
  }

  const register = e =>{
    e.preventDefault();

    // Some fancy firebase Registration(user)
    createUserWithEmailAndPassword(auth, email, password)
      .then((auth) => {
        if(auth){
          history('/');
        }
        // It successfully created a new user with email and password //test123temp123@gmail.com
        console.log(auth);
      })
      .catch(error => alert(error.message));
    }

  return (
    <div className='login'>

      <Link to='/'>
        <img className='login__logo' src='amazonLogoLightBD.png' alt='Amazon Logo' />
      </Link>

      <div className='login__container'>
        <h1>SignIn</h1>
        <form>
          <h5>Email</h5>
          <input type='email' value={email} onChange={e => setEmail(e.target.value)} />   {/* e stands for event here */}

          <h5>Password</h5>
          <input type='password' value={password} onChange={e => setPassword(e.target.value)}/>

          <button className='login__signInButton' type='submit' onClick={signIn}>Sign In</button>
        </form>

        <p>
        By signing-in you agree to the AMAZON FAKE CLONE Conditions of Use & Sale. 
        Please see our Privacy Notice, our Cookies Notice and our Interest-Based Ads Notice.
        </p>

        <button className='login__registrationButton' onClick={register}>Create your Amazon Account</button>
      </div>
    </div>
  )
}

export default Login;
