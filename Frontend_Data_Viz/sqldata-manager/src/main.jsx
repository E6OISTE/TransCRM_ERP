// import App from "./App";
import React from "https://esm.sh/react@19?dev";
import ReactDOM from "https://esm.sh/react-dom@19/client?dev";
import App from "./App";

const rootNode = document.getElementById("app");
const root = ReactDOM.createRoot(document.getElementById("app"));

root.render(
    <React.StrictMode>
        <App />
    </React.StrictMode>,
);
