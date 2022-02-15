import React,{useState} from 'react'

import art from './FullArt.module.css'
import defaultArticlePhoto from '../../../img/defaultArticlePhoto.jpg'
import ModalAddArticle from '../../ModalAddArticle/ModalAddArticle'
import ModalUpdateText from '../../ModalAddArticle/UpdateText/ModalUpdateText'


let FullArt = ({ oneArticle, postArticleWithPhoto, deleteArticlePhoto,updateText }) => {
	let deletePhoto = (articleId, photoId) => {
		deleteArticlePhoto(articleId, photoId)
	}
	return (
		<div className={art.postText}>
			<h1>{oneArticle.title}</h1>
			<ModalAddArticle
				artId={oneArticle.articleId}
				postArticleWithPhoto={postArticleWithPhoto}
			/>
			<div>
				<button
					onClick={() =>
						deletePhoto(oneArticle.articleId, oneArticle.photos[0].photoId)
					}
				>
					Видалити фото
				</button>
                <ModalUpdateText artId={oneArticle.articleId} updateText={updateText}/>
			</div>
			<img
				className={art.imageSize}
				src={
					oneArticle.photos[0]
						? `data:image/png;base64,${oneArticle.photos[0].fullPhoto}`
						: defaultArticlePhoto
				}
				alt='article-photo'
			/>
			<pre>{oneArticle.contents}</pre>
		</div>
	)
}
export default FullArt
