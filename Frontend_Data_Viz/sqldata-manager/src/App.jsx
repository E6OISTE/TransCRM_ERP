import React from "https://esm.sh/react@19?dev";
import ReactDOM from "https://esm.sh/react-dom@19/client?dev";
import "../css/App.css";

const App = () => {
    return (
        <>
            <div className="layout-container">
                {/*Sidebar*/}
                <aside className="sidebar">
                    <nav>
                        <ul>
                            <li>1</li>
                            <li>2</li>
                            <li>3</li>
                        </ul>
                    </nav>
                </aside>

                {/*Main area*/}
                <main>
                    {/*Top header*/}
                    <header className="top-header">
                        <h1>Page name</h1>
                    </header>

                    {/*Content*/}
                    <section className="page-body">
                        <p>You content...</p>
                    </section>
                </main>
            </div>
        </>
    );
};

export default App;
