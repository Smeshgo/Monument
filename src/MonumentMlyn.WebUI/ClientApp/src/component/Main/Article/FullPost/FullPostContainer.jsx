import React from "react";
import { connect } from "react-redux";

import FullPost from './FullPost'
import {getOneArticle} from '../../../Redux/articleReducer'
import { withRouter } from "react-router";
import { compose } from "redux";


class FullPostContainer extends React.Component {
    
    componentDidMount() {
        let articleId = this.props.match.params.articleId
        this.props.getOneArticle(articleId)
	}
    render() {
        return(
            <>
                <FullPost oneArticle={this.props.oneArticle}/>
            </>
        )
    }
}
let mapStateToProps = (state) => {
    return{
        oneArticle: state.articlePage.oneArticle
    }
}   

export default compose(withRouter,connect(mapStateToProps,{getOneArticle}))(FullPostContainer)