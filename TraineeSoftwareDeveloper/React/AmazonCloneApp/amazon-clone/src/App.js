import React from 'react'
import './App.css';
import Header from './Header.js'
import Home from './Home.js'

function App() {
  return (
    //BEM Convention
    <div className="App">
      {/* HEADER */}
      <Header />
      
      {/* HOME */}
      <Home />
    </div>
  );
}

export default App;
