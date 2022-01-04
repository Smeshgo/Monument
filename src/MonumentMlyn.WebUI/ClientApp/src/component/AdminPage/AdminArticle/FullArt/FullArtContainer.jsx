import React from 'react'
import { connect } from 'react-redux'

import FullArt from './FullArt'
import { getOneArticle } from '../../../Redux/articleReducer'
import {
	postArticleWithPhoto,
	deleteArticlePhoto,
} from '../../../Redux/articleReducer'
import { withRouter } from 'react-router'
import { compose } from 'redux'
class FullArtContainer extends React.Component {
	componentDidMount() {
		let articleId = this.props.match.params.articleId
		this.props.getOneArticle(articleId)
	}
	render() {
		return (
			<>
				<FullArt
					oneArticle={this.props.oneArticle}
					postArticleWithPhoto={this.props.postArticleWithPhoto}
					deleteArticlePhoto={this.props.deleteArticlePhoto}
				/>
			</>
		)
	}
}
let mapStateToProps = (state) => {
	return {
		oneArticle: state.articlePage.oneArticle,
	}
}

export default compose(
	withRouter,
	connect(mapStateToProps, {
		getOneArticle,
		postArticleWithPhoto,
		deleteArticlePhoto,
	})
)(FullArtContainer)
