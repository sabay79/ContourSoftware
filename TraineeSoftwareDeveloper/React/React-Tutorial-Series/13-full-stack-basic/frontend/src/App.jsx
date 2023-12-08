import { useEffect, useState } from 'react';
import axios from 'axios';
import './App.css';

function App() {

  const [jokes, setJokes] = useState([]);

  useEffect(() => {
    axios.get('/api/jokes')
    .then((response) => {setJokes(response.data)})
    .catch((error) => {console.log(error);})
  }, []);

  return (
    <>
    <h1>Basic Full Stack Application</h1>
    <h3>JOKES: {jokes.length}</h3>
    {
      jokes.map((joke, index) => (
        <div key={joke.id}>
          <h4>{joke.title}</h4>
        </div>
      ))
    }
    </>
  );
}

export default App;
