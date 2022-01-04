import React from 'react'

import MainPage from './component/MainPage/MainPage'
import AdminPage from './component/AdminPage/AdminPage'
import { connect } from 'react-redux'

let App = (props) => {
	return (
		<>
			{props.isAuth && props.nextPage ? <AdminPage/> : <MainPage/>}
		</>
	)
}
let AppContainer = (props) => {
	return(
		<App isAuth ={props.isAuth} nextPage={props.nextPage}/>
	)
}
let mapStatetoProps = (state) =>{
	return{
		isAuth: state.auth.isAuth,
		nextPage: state.auth.nextPage
	}
}
export default connect(mapStatetoProps, {})(AppContainer)