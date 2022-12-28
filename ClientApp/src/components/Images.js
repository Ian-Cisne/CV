import React, { Component } from 'react';

export class Images extends Component {
  static displayName = Images.name;

  constructor(props) {
    super(props);
    this.state = { images: [], loading: true };
  }

  static renderImagesTable(images) {
    return (
      <div className='img-table' aria-labelledby="tabelLabel">
          {images.map(image =>
            <img src={image.src}/>
          )}
      </div>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Images.renderImagesTable(this.state.images);
    return (
      <>
        {contents}
      </>
    );
  }
  async populateImagesData() {
    const response = await fetch('api/images');
    const data = await response.json();
    this.setState({ images: data, loading: false });
  }
}
