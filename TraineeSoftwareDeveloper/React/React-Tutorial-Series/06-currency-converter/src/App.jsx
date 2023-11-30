import useCurrencyInfo from './hooks/useCurrencyInfo';
import {InputBox} from './components';
import { useState } from 'react';

const App = () => {

  const [from, setFrom] = useState('pkr');
  const [to, setTo] =useState('usd');
  const [amount, setAmount] = useState(0);
  const [convertedAmount, setconvertedAmount] = useState(0);

  const currencyInfo = useCurrencyInfo(from);

  const conversionOptions = Object.keys(currencyInfo);

  const convert = () => {
    setconvertedAmount(amount * currencyInfo[to]);
  }

  const swap = () => {
    setFrom(to);
    setTo(from);

    setAmount(convertedAmount);
    setconvertedAmount(amount);
  }

  return (
    <div
      className="w-full h-screen flex flex-wrap justify-center items-center bg-cover bg-no-repeat"
      style={{
          backgroundImage: `url('https://images.unsplash.com/photo-1634176866089-b633f4aec882?q=80&w=1480&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D')`,
        }}
    >
      <div className="w-full">
        <div className="w-full max-w-md mx-auto border border-gray-60 rounded-lg p-10 backdrop-blur-sm bg-white/30">
          <form onSubmit={(e) => {
            e.preventDefault();
            convert();
            }}
          >
            <div className="w-full mb-1">
                <InputBox
                  label="From"
                  amount = {amount}
                  currencyOptions = {conversionOptions}
                  onCurrencyChange = {(currency) => setFrom(currency)}
                  selectCurrency = {from}
                  onAmountChange={(amount) => setAmount(amount)}
                />
            </div>

            <div className="relative w-full h-0.5">
              <button
                type="button"
                className="absolute left-1/2 -translate-x-1/2 -translate-y-1/2 border-2 border-white rounded-md bg-blue-600 text-white px-2 py-0.5"
                onClick={swap}
              >SWAP</button>
            </div>

            <div className="w-full mt-1 mb-3">
                <InputBox 
                  label="To" 
                  amount = {convertedAmount}
                  currencyOptions = {conversionOptions}
                  onCurrencyChange = {(currency) => setTo(currency)}
                  selectCurrency = {to}
                  amountDisable
                />
            </div>

            <button type="submit" className="w-full bg-blue-600 text-white px-4 py-3 rounded-lg">
                CONVERT {from.toUpperCase()} to {to.toUpperCase()}
            </button>

          </form>
        </div>
      </div>
    </div>
  );
}

export default App;
