import Home from "./Components/Home";
import {BrowserRouter, Routes, Route,} from "react-router-dom";
import Feed from "./Components/Feed";

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route exact path="/" element={<Home />} />
        <Route path="feed" element={<Feed/>} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;


// make a logo