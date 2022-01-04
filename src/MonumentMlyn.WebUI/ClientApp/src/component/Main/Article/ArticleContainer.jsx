import React from 'react'
import { connect } from 'react-redux'

import Article from './Article'
import { getArticles } from '../../Redux/articleReducer'
import * as axios from 'axios'
class ArticleContainer extends React.Component {
	componentDidMount() {
		this.props.getArticles()
	}
	render() {
		return (
			<>
				<Article articles={this.props.articles} />
			</>
		)
	}
}
let mapStateToProps = (state) => {
	return {
		articles: state.articlePage.articles,
	}
}
export default connect(mapStateToProps, { getArticles })(ArticleContainer)
