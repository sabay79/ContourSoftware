import { useState } from 'react';

function App() {

  let [bgColor, setBgColor] = useState('wheat');

  return (
    <div className="w-full h-screen duration-200" style={{backgroundColor: bgColor}}>
      <div className="fixed flex flex-wrap justify-center bottom-10 inset-x-0 px-2">
        <div className="flex flex-wrap justify-center gap-3 shadow-lg bg-white px-3 py-2 rounded-3xl text-white">          
          <button onClick={() => setBgColor('red')} className='outline-none px-4 py-1 rounded-full shadow-lg' style={{backgroundColor: 'red'}}>RED</button>
          <button onClick={() => setBgColor('gold')} className='outline-none px-4 py-1 rounded-full shadow-lg' style={{backgroundColor: 'gold'}}>YELLOW</button>
          <button onClick={() => setBgColor('green')} className='outline-none px-4 py-1 rounded-full shadow-lg' style={{backgroundColor: 'green'}}>GREEN</button>
          <button onClick={() => setBgColor('blue')} className='outline-none px-4 py-1 rounded-full shadow-lg' style={{backgroundColor: 'blue'}}>BLUE</button>
          <button onClick={() => setBgColor('pink')} className='outline-none px-4 py-1 rounded-full shadow-lg' style={{backgroundColor: 'pink'}}>PINK</button>
          <button onClick={() => setBgColor('purple')} className='outline-none px-4 py-1 rounded-full shadow-lg' style={{backgroundColor: 'purple'}}>PURPLE</button>
          <button onClick={() => setBgColor('coral')} className='outline-none px-4 py-1 rounded-full shadow-lg' style={{backgroundColor: 'coral'}}>CORAL</button>
          <button onClick={() => setBgColor('olive')} className='outline-none px-4 py-1 rounded-full shadow-lg' style={{backgroundColor: 'olive'}}>OLIVE</button>
          <button onClick={() => setBgColor('teal')} className='outline-none px-4 py-1 rounded-full shadow-lg' style={{backgroundColor: 'teal'}}>TEAL</button>
        </div>
      </div>
    </div>
  )
}

export default App;
