import React, { StrictMode } from 'react';
import ReactDOM from 'react-dom/client';
import { Provider } from 'react-redux';
import { RouterProvider, createBrowserRouter } from 'react-router-dom';

import './index.css';
import store from './store/store.js';

import App from './App.jsx';
import Home from './pages/Home.jsx';
import { AuthLayout, Login } from './components/index.js';
import SignUp from './pages/SignUp.jsx';
import Post from './pages/Post.jsx';
import AllPosts from './pages/AllPosts.jsx';
import AddPost from './pages/AddPost.jsx';
import UpdatePost from './pages/UpdatePost.jsx';

const router = createBrowserRouter([
  {
    path: '/',
    element: <App />,
    children: [
      {
        path: '', 
        element: <Home/>
      },
      {
        path:'login', 
        element: (
          <AuthLayout authentication={false}>
            <Login />
          </AuthLayout>
        )
      },
      {
        path: 'signup',
        element: (
          <AuthLayout authentication={false}>
            <SignUp />
          </AuthLayout>
        )
      },
      {
        path: 'post/:slug',
        element: <Post />
      },
      {
        path: 'all-posts',
        element: (
          <AuthLayout authentication>
            {' '}
            <AllPosts />
          </AuthLayout>
        )
      },
      {
        path: 'add-post',
        element: (
          <AuthLayout authentication>
            {' '}
            <AddPost />
          </AuthLayout>
        )
      },
      {
        path: 'update-post/:slug',
        element: (
          <AuthLayout authentication>
            {' '}
            <UpdatePost />
          </AuthLayout>
        )
      }
    ]
  }
]);

ReactDOM.createRoot(document.getElementById('root')).render(
  <StrictMode>
    <Provider store={store}>
      <RouterProvider router={router} />
    </Provider>
  </StrictMode>,
)
