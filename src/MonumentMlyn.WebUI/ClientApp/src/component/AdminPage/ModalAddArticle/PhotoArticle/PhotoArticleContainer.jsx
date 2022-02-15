import React from 'react'
import { connect } from 'react-redux'

import PhotoArticle from './PhotoArticle'
import {
    getAllPhotoForArticle,
    pageChanged
} from '../../../Redux/articleReducer'

class PhotoArticleContainer extends React.Component {
	componentDidMount() {
		this.props.getAllPhotoForArticle()
	}
	
	onPageChanged = (thisPage) => {
		this.props.pageChanged(thisPage, this.props.pageNumbers)
	}
	render() {
		return (
			<>
				<PhotoArticle
					articlesPhoto={this.props.articlesPhoto}
					pageNumbers={this.props.pageNumbers}
					countArticlesPhoto={this.props.countArticlesPhoto}
					thisPage={this.props.thisPage}
                    onPageChanged={this.onPageChanged}
					onSubmit={this.props.onSubmit}
					closeModal={this.props.closeModal}
				/>
			</>
		)
	}
}
let mapStateToProps = (state) => {
	return {
		articlesPhoto: state.articlePage.articlesPhoto,
		pageNumbers: state.articlePage.pageNumbers,
		countArticlesPhoto: state.articlePage.countArticlesPhoto,
		thisPage: state.articlePage.thisPage,
	}
}
export default connect(mapStateToProps, {
	getAllPhotoForArticle,
    pageChanged
})(PhotoArticleContainer)
