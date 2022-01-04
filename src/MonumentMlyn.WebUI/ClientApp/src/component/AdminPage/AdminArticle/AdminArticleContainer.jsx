import React from "react";
import { connect } from "react-redux";

import AdminArticle from './AdminArticle'
import {getArticles,deleteArticle} from '../../Redux/articleReducer'


class AdminArticleContainer extends React.Component {
    
    componentDidMount() {
		this.props.getArticles()
	}
    render() {
        return(
            <>
                <AdminArticle articles={this.props.articles} deleteArticle={this.props.deleteArticle}/>
            </>
        )
    }
}
let mapStateToProps = (state) => {
    return{
        articles: state.articlePage.articles
    }
}   
export default connect(mapStateToProps,{getArticles, deleteArticle})(AdminArticleContainer)