import React, { useEffect } from 'react'
import './App.css';
import Header from './Header.js'
import Home from './Home.js'
import Checkout from './Checkout.js';
import Login from './Login.js';
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import {auth} from "./firebase.js";
import { onAuthStateChanged } from "firebase/auth";
import { useStateValue } from './StateProvider';

function App() {
  const [{}, dispatch] = useStateValue();

  useEffect(() => {
    // will only run once when the app component loads...
    onAuthStateChanged(auth, (authUser) => {
      console.log('The User is >>>', authUser);

      if (authUser) {
        // User is signed in, see docs for a list of available properties
        // https://firebase.google.com/docs/reference/js/auth.user'

        dispatch({
          type: 'SET_USER',
          user: authUser
        })
      } 
      else {
        // User is signed out
        dispatch({
          type: 'SET_USER',
          user: null
        })
      }
    });
    
  }, []);

  return (
    //BEM Convention
      <Router>
        <div className="App">   
          <Routes>
            <Route path='/login' element={<Login/>} />
            <Route path='/checkout' element= {
              <>
                <Header />
                <Checkout />
              </>} 
            />
            <Route path='/' element= {
              <>
                <Header />
                <Home />
              </>} 
            />
          </Routes>
        </div>
      </Router>
  );
}

export default App;
