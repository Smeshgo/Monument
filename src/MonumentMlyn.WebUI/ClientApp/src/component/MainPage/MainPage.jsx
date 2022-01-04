import React from 'react'

import { BrowserRouter as Router, Switch, Route } from 'react-router-dom'

import HeaderContainer from '../Main/Header/HeaderContainer'
import Main from '../Main/Main'
import FooterContainer from '../Main/Footer/FooterContainer'
import GalleryContainer from '../Main/Galery/GalleryContainer'
import ArticleContainer from '../Main/Article/ArticleContainer'
import FullPostContainer from'../Main/Article/FullPost/FullPostContainer'

let MainPage = () => {
	return (
		<Router>
			<HeaderContainer/>
			<Switch>
				<Route exact path='/main' component={Main} />
				<Route exact path='/gallery/:category' component={GalleryContainer} />
				<Route exact path='/article' component={ArticleContainer} />
				<Route exact path='/article/:articleId' component={FullPostContainer} />
				<Route path='/' component={Main}/>				
			</Switch>
			<FooterContainer/>
		</Router>
	)
}
export default MainPage