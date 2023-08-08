import React from 'react'
import './App.css';
import Header from './Header.js'
import Home from './Home.js'
import Checkout from './Checkout.js';
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";

function App() {
  return (
    //BEM Convention
    <>
      <Router>
        <div className="App">
          <Header />        
          <Routes>
            <Route path='/checkout' element={<Checkout/>} />
            <Route path='/' element={<Home/>} />
          </Routes>
        </div>
      </Router>
    </>
  );
}

export default App;
