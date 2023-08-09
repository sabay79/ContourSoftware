import React from 'react'
import './App.css';
import Header from './Header.js'
import Home from './Home.js'
import Checkout from './Checkout.js';
import Login from './Login.js';
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";

function App() {
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
