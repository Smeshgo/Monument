import React from 'react'

import SmallPost from './SmallPost/SmallPost'
import a from './Article.module.css'

let Article = (props) => {
	return (
		<div className={a.bckgroung}>
			<div className={a.topBlock}>
				<h1>Шось загальне</h1>
				<p>
					Lorem ipsum dolor sit amet consectetur adipisicing elit. Debitis
					exercitationem sed dolores incidunt libero maiores quod nisi eaque
					recusandae, aut, natus quam pariatur eos? Est aliquid debitis
					consequatur maiores magni.
				</p>
			</div>
			<div className={a.posit}>
			{props.articles.map((p) => (
				<SmallPost 
                key={p.articleId}
                photos={p.photos} 
                title={p.title}
                articleId={p.articleId}
                />
			))}
			</div>
		</div>
	)
}

export default Article
