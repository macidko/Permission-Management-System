import Login from "../../pages/Login/Login";
import Register from "../../pages/Register/Register";
import Landing from "../../pages/LandingPage/Landing";
import {
  RouterProvider,
  createBrowserRouter,
  createRoutesFromElements,
  Route,
} from "react-router-dom";
import Home from "../../pages/Home/Home";

const appRouter = createBrowserRouter(
  createRoutesFromElements(
    <>
      <Route path="/" element={<Landing />} />
      <Route path="/login" element={<Login />} />
      <Route path="/register" element={<Register />} />
      <Route path="/home" element={<Home />} />
    </>
  )
);

const RouteDefinitions = () => {
  return <RouterProvider router={appRouter}></RouterProvider>;
};

export default RouteDefinitions;
