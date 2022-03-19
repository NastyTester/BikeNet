import React from 'react';
import { Route } from 'react-router';
import Home from './components/Home';

import './custom.css'

export default function App() {

    return (
        <Route exact path='/' component={Home} />
    );
  
}
