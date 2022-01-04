import React from 'react'
import { connect } from 'react-redux'

import AddNewArticle from './AddNewArticle'
import { postArticleWithoutPhoto } from '../../Redux/articleReducer'

let AddNewArticleContainer = (props) => {
	return (
		<>
			<AddNewArticle  postArticleWithoutPhoto={props.postArticleWithoutPhoto}/>
		</>
	)
}

export default connect(null,{ postArticleWithoutPhoto })(AddNewArticleContainer)