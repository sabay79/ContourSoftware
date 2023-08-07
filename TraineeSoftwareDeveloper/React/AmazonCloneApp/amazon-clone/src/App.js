import React from 'react'
import './App.css';
import Header from './Header.js'
import Home from './Home.js'
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import CheckOut from './Checkout.js';

function App() {
  return (
    //BEM Convention
    <Router>
      <div className="App">
      <Header />        
        <Switch>

          <Route path='/checkout'>
            <CheckOut />
          </Route>

          <Route path='/'>
            <Home />
          </Route>

        </Switch>
      </div>
    </Router>
  );
}

export default App;
