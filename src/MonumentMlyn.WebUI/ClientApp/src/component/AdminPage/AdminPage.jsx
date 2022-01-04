import React from "react";
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom'

import NavBarContainer from './NavBar/NavBarContainer'
import Dashbord from './Dashbord/Dashbord'
import AddNewArticleContainer from './AddNewArticle/AddNewArticleContainer'
import AdminArticleContainer from "./AdminArticle/AdminArticleContainer";
import AdminGalleryContainer from "./AdminGalery/AdminGaletyContainer";
import CreatePhotoContainer from "./CreatePhoto/CreatePhotoContainer";
import a from './AdminPage.module.css'
import HeaderContainer from "./Header/HeaderContainer" ;
import FullArtContainer from './AdminArticle/FullArt/FullArtContainer'

let AdminPage = ( ) => {
    return(
        <Router>
        <div className={a.fullBlock}>
            <NavBarContainer/>
            <HeaderContainer/>
			<Switch className={a.content}>
				<Route exact path='/admin/dashbord' component={Dashbord} />
				<Route exact path='/admin/createArticle' component={AddNewArticleContainer} />
                <Route exact path='/admin/createPhoto' component={CreatePhotoContainer} />
				<Route exact path='/admin/article' component={AdminArticleContainer} />
                <Route exact path='/admin/article/:articleId' component={FullArtContainer} />
				<Route exact path='/admin/gallery/:category' component={AdminGalleryContainer} />
				<Route exact path='/' component={Dashbord}/>
			</Switch>	
        </div> 
        </Router>
    )
}
export default AdminPage