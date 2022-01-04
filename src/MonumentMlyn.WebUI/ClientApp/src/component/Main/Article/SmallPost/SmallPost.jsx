import React from 'react'
import { NavLink } from 'react-router-dom'

import p from './SmallPost.module.css'
import arrow from '../../../img/arrow.png'
import defaultPhoto from '../../../img/defaultArticlePhoto.jpg'


let SmallPost = ({photos,title,articleId}) => {
	return (
		<div className={p.blockPost}>
				<NavLink to={'article/' + articleId}>
					<img className={p.photo}
						src={photos[0] ? `data:image/png;base64,${photos[0].minyPhoto}` : defaultPhoto}
						alt='post-image'
					/>
					<div className={p.h4}>
						<span>{title}</span>
					</div>
					<div className={p.icon}>
						<img src={arrow} alt="arrow" />
					</div>
				</NavLink>
		</div>
	)
}
export default SmallPost
