import React from 'react'

import art from './FullArt.module.css'
import defaultArticlePhoto from '../../../img/defaultArticlePhoto.jpg'
import ModalAddArticle from '../../ModalAddArticle/ModalAddArticle'

let FullArt = ({ oneArticle, postArticleWithPhoto,deleteArticlePhoto }) => {	

    let deletePhoto = (articleId,photoId) => {
        deleteArticlePhoto(articleId,photoId)
    }
	return (
		<div className={art.postText}>
            <h1>{oneArticle.title}</h1>
            <ModalAddArticle artId={oneArticle.articleId} postArticleWithPhoto={postArticleWithPhoto} />
            <div><button onClick={()=>deletePhoto(oneArticle.articleId,oneArticle.photos[0].photoId)}>Видалити фото</button></div>
            <img className={art.imageSize} src={oneArticle.photos[0] ? `data:image/png;base64,${oneArticle.photos[0].fullPhoto}` : defaultArticlePhoto} alt="article-photo" />
            <pre>{oneArticle.contents}</pre>
        </div>
	)
}
export default FullArt
