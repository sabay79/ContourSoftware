import { useState } from 'react';
import './App.css';

function App() {
  let [count, setCount] = useState(15);

  const addValue = () => {
    if(count <= 7){
      setCount(count++);
    } else {
      alert('Reached Maximum Limit');
    }  
  }

  const removeValue = () => {
    if(count >= 0) {
      setCount(count--);
    } else {
      alert('Reached Minimum Limit');
    }
  }

  return (
    <>
      <h1>Counter</h1>
      
      <h1><em>{count}</em></h1>

      <button onClick={addValue}>Add Value</button>
      <button onClick={removeValue}>Remove Value</button>
    </>
  )
}

export default App;
