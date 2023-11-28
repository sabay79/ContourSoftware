import { useState } from 'react';
import './App.css';

function App() {
  let [count, setCount] = useState(3);

  const addValue = () => {
    if(count <= 7){
      setCount(count + 1);

      //#region Only increment by 1 
      // setCount(count + 1);
      // setCount(count + 1);
      // setCount(count + 1);
      //#endregion

      //#region increment by no of calls(3)
      // setCount(prevCount => prevCount + 1)
      // setCount(prevCount => prevCount + 1)
      // setCount(prevCount => prevCount + 1)
      //#endregion

      //#region increment by no of calls(3)
      setCount(count++);
      setCount(count++);
      setCount(count++);
      //#endregion

      //#region increment by no of calls-1(2)
      // setCount(++count);
      // setCount(++count);
      // setCount(++count);
      //#endregion

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
