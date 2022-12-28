import React, { Component } from 'react';

export class Login extends Component {
  static displayName = Login.name;
  constructor(props) {
    super(props);
    this.state = {
      errorMessage: {
        name: '',
        message: ''
      },
      isSubmited: false
    };
    this.renderErrorMessage = this.renderErrorMessage.bind(this);
    this.handleSubmit = this.handleSubmit.bind(this);
  }
  renderErrorMessage(name) {
    if(name === this.state.errorMessage.name) {
      return (
        <div className="error">{this.state.errorMessage.message}</div>
      )
    }
    else {
      return ''
    }
  }
  handleSubmit (event) {
    // Prevent page reload
    event.preventDefault();
  };
  render () {
    return (
      <form onSubmit={this.handleSubmit}>
        <label for="username">
          Nombre de usuario:
        </label>
        <input type="text" id="username" minLength="5" maxLength="30" required/>
        {this.renderErrorMessage("username")}
        <label for="username">
          Contraseña:
        </label>
        <input type="password" id="password" minLength="8" maxLength="50" required/>
        {this.renderErrorMessage("password")}

        <input type="submit" value="Login"/>
      </form>
    );
  }
}
