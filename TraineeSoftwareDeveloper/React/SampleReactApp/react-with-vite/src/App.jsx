import { useState } from 'react'
import './App.css'
import Card from './components/Card'
import Nav from './components/Nav'
import Contact from './components/Contact';
import ToDo from './components/ToDo';

function App() {
  const [color, setColor] = useState("Toggle Color");

  const toggleColor = () => {
    if(color == "Black")
      setColor("Blue");
    else
    setColor("Black");
  }

  return (
    <>
      <Nav />
      <h1>This is App.jsx</h1>

      <button onClick={toggleColor}>Toggle Color</button>
      <input onChange={toggleColor} type="text" name="" />
      <h2>My Favorite Color is {color}</h2>

      <Card name="Basic" price={5} />
      <Card name="Standard" price={10} />
      <Card name="Corporate" price={15} />

      <h2>Contact Form</h2>
      <Contact />

      <ToDo />
    </>
  )
}

export default App
