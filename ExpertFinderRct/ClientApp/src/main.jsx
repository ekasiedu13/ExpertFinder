import React from 'react'
import ReactDOM from 'react-dom/client'
import {
    createBrowserRouter,
    RouterProvider,
} from "react-router-dom";

import HomeNav from "./components/navbar/HomeNav.jsx";
import Footer from "./components/Footer.jsx";

import About from "./pages/About.jsx";
import Contact from "./pages/Contact.jsx";
import Home from "./pages/Home.jsx";
import Login from "./pages/Login.jsx";
import Register from "./pages/Register.jsx";

import App from './App.jsx'
// import './index.css'

const navFunction = (Page) => (
    <>
        <HomeNav />
        <Page />
        <Footer />
    </>
)

const router = createBrowserRouter([
    {
        path: "/",
        element: navFunction(Home),
    },    
    {
        path: "/home",
        element: navFunction(Home),
    },    
    {
        path: "/about",
        element: navFunction(About),
    },    
    {
        path: "/contact",
        element: navFunction(Contact),
    },    
    {
        path: "/register",
        element: navFunction(Register),
    },    
    {
        path: "/login",
        element: navFunction(Login),
    },
]);

ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
    {/*<App />*/}
    <RouterProvider router={router} />
  </React.StrictMode>,
)
