import React from "react";

import f from './FullPost.module.css'
import defaultArticlePhoto from '../../../img/defaultArticlePhoto.jpg'


let FullPost = ({oneArticle}) => {
    return(
        <div className={f.postText}>
            <h1>{oneArticle.title}</h1>
            <img className={f.imageSize} src={oneArticle.photos[0] ? `data:image/png;base64,${oneArticle.photos[0].fullPhoto}` : defaultArticlePhoto} alt="article-photo" />
            <pre>{oneArticle.contents}</pre>
        </div>
    )
}
export default FullPost