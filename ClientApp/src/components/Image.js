import React, { Component } from 'react';

export class Image extends Component {
  static displayName = Image.name;

  constructor(props) {
    super(props);
    this.state = { currentCount: 0 };
    this.incrementCounter = this.incrementCounter.bind(this);
  }

  incrementCounter() {
    this.setState({
      currentCount: this.state.currentCount + 1
    });
  }

  render() {
    return (
      <figure>
        <img src={this.props.imageSrc}/>
      </figure>
    );
  }
}
