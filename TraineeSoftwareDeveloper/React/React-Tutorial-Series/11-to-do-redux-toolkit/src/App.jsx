import React from "react";
import AddTodo from "./components/AddTodo";
import Todos from "./components/Todos";
import './App.css'

function App() {

  return (
    <div className="m-50">
      <AddTodo />
      <Todos />
    </div>
  )
}

export default App;
