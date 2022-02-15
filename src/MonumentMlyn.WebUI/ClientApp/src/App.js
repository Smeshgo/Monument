import React, {useEffect} from 'react'
import Cookies from 'js-cookie'
import { connect } from 'react-redux'

import MainPage from './component/MainPage/MainPage'
import AdminPage from './component/AdminPage/AdminPage'
import {authMe,	nextPage} from './component/Redux/authReducer'


let App = (props) => {
	useEffect(() => {
		if(Cookies.get('user') && Cookies.get('nextPage')){
			props.authMe(true);
			props.nextPage(true);
		}
	}, []);
	return (
		<>
			{props.isAuth && props.NextPage ? <AdminPage/> : <MainPage/>}
		</>
	)
}
let AppContainer = (props) => {
	return(
		<App isAuth ={props.isAuth} NextPage={props.NextPage} authMe={props.authMe} nextPage={props.nextPage}/>
	)
}
let mapStatetoProps = (state) =>{
	return{
		isAuth: state.auth.isAuth,
		NextPage: state.auth.NextPage
	}
}
export default connect(mapStatetoProps, {authMe,nextPage})(AppContainer)