import React from 'react'
import { NavLink } from 'react-router-dom'

import am from './SmallArt.module.css'
import arrow from '../../../img/arrow.png'
import trash from '../../../img/trash-5-32.png'
import defaultPhoto from '../../../img/defaultArticlePhoto.jpg'

let SmallArt = ({photos,title,articleId,deleteArticle}) => {
	return (
		<div className={am.blockPost}>
				<div className={am.iconDel}>
					<img src={trash} alt="arrow" onClick={()=>{deleteArticle(articleId)}}/>
				</div>
				<NavLink to={'article/' + articleId}>
					<img className={am.photo}
						src={photos[0] ? `data:image/png;base64,${photos[0].minyPhoto}` : defaultPhoto}
						alt='post-image'
					/>
					<div className={am.descr}>
						<span>{title}</span>
					</div>
					<div className={am.icon}>
						<img src={arrow} alt="arrow" />
					</div>
					
				</NavLink>
		</div>
	)
}
export default SmallArt