import { BrowserRouter, Route, Routes } from "react-router-dom"
import Home from "../components/Home"
import Create from "../components/Home/Create"
import Update from "../components/Home/Update"
import Read from "../components/Home/Read"

function Router() {
    return(
        <BrowserRouter>
            <Routes>
                <Route path="/" element={<Home />}></Route>
                <Route path="/create" element={<Create />}></Route>
                <Route path="/update/:id" element={<Update />}></Route>
                <Route path="/read/:id" element={<Read />}></Route>
            </Routes>
        </BrowserRouter>
    )
}

export default Router
