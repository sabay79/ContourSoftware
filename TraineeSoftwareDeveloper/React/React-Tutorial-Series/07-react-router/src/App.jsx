import { Outlet } from 'react-router-dom';
import {Header, Footer} from './components';

function App() {

  return (
    <>
      <Header />
      <Outlet />
      <Footer />
    </>
  )
}

export default App;
