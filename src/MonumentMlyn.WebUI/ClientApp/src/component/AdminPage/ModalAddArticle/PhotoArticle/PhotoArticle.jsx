import React from 'react'

import pa from './PhotoArticle.module.css'
import Paginator from '../../../common/Pagination/Pagination'

let PhotoArticle = (props) => {
	return (
		<div className={pa.gallery}>
			<div className={pa.position} >
				{props.articlesPhoto.map((photo, index) => (
					<div key={index} className={pa.text}>
						<img
							src={`data:image;base64,${photo.minyPhoto}`}
							alt='gallery-photo'
							onClick={()=>props.onSubmit(photo.photoId)}
						/>
						<div className={pa.text1}>
							<span>{photo.name}</span>
						</div>
					</div>
				))}
			</div>
			<Paginator 
			pageSize={props.pageNumbers}
			totalPhotoCount={props.countArticlesPhoto}
			currentPage={props.thisPage}
			onPageChanged={props.onPageChanged}
			/>
		</div>
	)
}
export default PhotoArticle
