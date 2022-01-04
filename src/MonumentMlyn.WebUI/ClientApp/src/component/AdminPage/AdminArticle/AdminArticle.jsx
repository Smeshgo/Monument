import React from 'react'
import { NavLink } from 'react-router-dom'

import aa from './AdminArticle.module.css'
import plus from '../../img/plus.png'
import SmallArt from './SmallArt/SmallArt'

let AdminArticle = (props) => {
	return (
		<div className={aa.grid}>
			<div className={aa.blockAdd}>
				<NavLink to='/admin/createArticle'>
					<img src={plus} alt='add' />
				</NavLink>
			</div>
			{props.articles.map((p) => (
				<SmallArt
                key={p.articleId}
                photos={p.photos} 
                title={p.title}
                articleId={p.articleId}
				deleteArticle={props.deleteArticle}
                />

			))}
		</div>
	)
}

export default AdminArticle
