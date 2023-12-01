import { useEffect, useState } from 'react';
import './App.css';
import { ThemeProvider } from './context/Theme';
import ThemeBtn from './components/ThemeBtn';
import Card from './components/Card';

function App() {

  const [themeMode, setThemeMode] = useState('light');

  const lightTheme = () => {
    setThemeMode('light');
  }

  const darkTheme = () => {
    setThemeMode('dark');
  }

  // Actual Change in a Theme
  useEffect(() => {

    const htmlClassList = document.querySelector('html').classList;
    
    htmlClassList.remove('light', 'dark');
    htmlClassList.add(themeMode);
  }, [themeMode]);

  return (
    <ThemeProvider value={{themeMode, lightTheme, darkTheme}}>
      <div className="flex flex-wrap min-h-screen items-center">
        <div className="w-full">
            <div className="w-full max-w-sm mx-auto flex justify-end mb-4">
              {/* ThemeBtn */}
              <ThemeBtn/>
            </div>

            <div className="w-full max-w-sm mx-auto">
              {/* Card */}
              <Card/>
            </div>
        </div>
      </div>
    </ThemeProvider>
  )
}

export default App
