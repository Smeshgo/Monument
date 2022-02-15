import React from 'react'
import { connect } from 'react-redux'

import AdminGalery from './AdminGalery'
import {
	getPhotos,
	getPageChanged,
	getPhoto,
	setPhotoIndex,
	deleteThisPhoto
} from '../../Redux/galleryReducer'

class AdminGalleryContainer extends React.Component {
	componentDidMount() {
		let category = this.props.match.params.category
		this.props.getPhotos(category)
	}
	componentDidUpdate(prevProps,prevState){
		if(this.props.photoIndex != prevProps.photoIndex){
			this.props.getPhoto(this.props.allPhoto[this.props.photoIndex].photoId)
		}
		let category = this.props.match.params.category
		if(category!= prevProps.category){
			this.props.getPhotos(category)
		}
	}
	onPageChanged = (pageNumber) => {
		this.props.getPageChanged(this.props.category, pageNumber, this.props.pageSize)
	}
	render() {
		return (
			<>
				<AdminGalery
					allPhoto={this.props.allPhoto}
					photo={this.props.photo}
					pageSize={this.props.pageSize}
					totalPhotoCount={this.props.totalPhotoCount}
                    currentPage={this.props.currentPage}
                    onPageChanged={this.onPageChanged}
					getPhoto={this.props.getPhoto}
					setPhotoIndex={this.props.setPhotoIndex}
					photoIndex={this.props.photoIndex}
					deleteThisPhoto={this.props.deleteThisPhoto}
					category={this.props.category}
				/>
			</>
		)
	}
}
let mapStateToProps = (state) => {
	return {
		allPhoto: state.galleryPage.allPhoto,
		pageSize: state.galleryPage.pageSize,
		totalPhotoCount: state.galleryPage.totalPhotoCount,
		currentPage: state.galleryPage.currentPage,
        category: state.galleryPage.category,
		photo: state.galleryPage.photo,
		photoIndex: state.galleryPage.photoIndex
	}
}
export default connect(mapStateToProps, {
	getPhotos,
	getPageChanged,
	getPhoto,
	setPhotoIndex,
	deleteThisPhoto
})(AdminGalleryContainer)
