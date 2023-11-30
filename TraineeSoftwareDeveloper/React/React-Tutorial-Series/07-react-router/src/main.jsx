import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';

import {Route, RouterProvider, createBrowserRouter, createRoutesFromElements} from 'react-router-dom';
import App from './App';
import { Home, About, Contact, User, GitHub, gitHubInfoLoader } from './components';

// Approach 01
// const router = createBrowserRouter([
//   {
//     path: '/', 
//     element: <App />,
//     children: [
//       { path:'', element: <Home/> },
//       { path:'about', element: <About/> },
//       { path:'contact', element: <Contact/> }
//     ]
//   }
// ])

// Approach 02
const router = createBrowserRouter(
  createRoutesFromElements(
    <Route path='/' element={<App/>}>
      <Route path='' element= {<Home/>}/>
      <Route path='about' element= {<About/>}/>
      <Route path='contact' element= {<Contact/>}/>
      <Route path='user/:id' element= {<User/>}/>
      <Route 
        loader={gitHubInfoLoader}
        path='github' 
        element= {<GitHub/>}
      />
    </Route>
  )
)

ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
    <RouterProvider router={router} />
  </React.StrictMode>
);
