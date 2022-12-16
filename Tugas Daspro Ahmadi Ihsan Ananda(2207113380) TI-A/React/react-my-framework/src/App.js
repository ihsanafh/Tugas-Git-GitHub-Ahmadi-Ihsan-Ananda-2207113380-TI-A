import React, { Component } from 'react';
import { BrowserRouter as Router, Route, Link, Routes } from 'react-router-dom';
import logo from './logoo_unri.png';
import './App.css';
import User from './components/User.js';
import Blog from './components/Blog.js';
import Account from './components/Account.js';

class App extends Component {
  render() {
    return (
      <Router>
        <div>
          <Link to="/">|Home|</Link>
          <Link to="/Account">Account</Link>
          <Link to="/Blog">|Blog|</Link>
          <hr />
          <img src={logo} className="App-logo" alt="logo" />
          <Routes>
          <Route exact path="/" element={<User/>}/>
          <Route path="/Blog" element={<Blog/>}/>
          <Route path="/Account" element={<Account/>}/>
          </Routes>
        </div>
      </Router>
    );
  }
}

export default App;
