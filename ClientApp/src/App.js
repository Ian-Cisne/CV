import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Inicio } from './components/Inicio';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { Images } from './components/Images';
import { Login } from './components/Login';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Inicio} />
        <Route path='/counter' component={Counter} />
        <Route path='/fetch-data' component={FetchData} />
        <Route path='/images' component={Images} />
        <Route path='/login' component={Login} />
      </Layout>
    );
  }
}
