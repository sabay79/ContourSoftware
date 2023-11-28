import { useState, useCallback } from 'react';

function App() {

  const [length, setLength] = useState(8);
  const [isNumber, setIsNumber] = useState(true);
  const [isChar, setIsChar] = useState(true);
  const [password, setPassword] = useState('');

  const passwordGenerator = useCallback(() => {

    let pwd = '';
    let str = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz';
    
    if(isNumber) str += '0123456789';
    if(isChar) str += '!@#$%^&*-_+=[]{}~`';

    for(let i = 1; i<=length; i++) {
      let char = Math.floor(Math.random() * str.length);
      pwd = str.charAt(char);
    }

    setPassword(pwd);

  }, [length, isNumber, isChar, setPassword]);

  return (
    <>
      <div className="w-full max-w-md mx-auto my-8 shadow-md rounded-lg px-4 py-4 text-orange-500 bg-gray-200">
        <h1 className='text-black text-center text-3xl mb-4'>Password Generator</h1>
        <div className="flex shadow ounded-lg overflow-hidden mb-4">
          <input 
            type="text" 
            value={password}
            placeholder='Password'
            className='outline-none w-full py-1 px-3'
            readOnly />
          <button className='outline-none bg-blue-700 text-white px-3 py-0.5 shrink-0'>
            <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" strokeWidth={1.5} stroke="currentColor" className="w-6 h-6">
              <path strokeLinecap="round" strokeLinejoin="round" d="M9 12h3.75M9 15h3.75M9 18h3.75m3 .75H18a2.25 2.25 0 002.25-2.25V6.108c0-1.135-.845-2.098-1.976-2.192a48.424 48.424 0 00-1.123-.08m-5.801 0c-.065.21-.1.433-.1.664 0 .414.336.75.75.75h4.5a.75.75 0 00.75-.75 2.25 2.25 0 00-.1-.664m-5.8 0A2.251 2.251 0 0113.5 2.25H15c1.012 0 1.867.668 2.15 1.586m-5.8 0c-.376.023-.75.05-1.124.08C9.095 4.01 8.25 4.973 8.25 6.108V8.25m0 0H4.875c-.621 0-1.125.504-1.125 1.125v11.25c0 .621.504 1.125 1.125 1.125h9.75c.621 0 1.125-.504 1.125-1.125V9.375c0-.621-.504-1.125-1.125-1.125H8.25zM6.75 12h.008v.008H6.75V12zm0 3h.008v.008H6.75V15zm0 3h.008v.008H6.75V18z" />
            </svg>
          </button>
        </div>
      </div>
    </>
  )
}

export default App;
