import React from 'react'
import { connect } from 'react-redux'

import Header from './Header'
import { login, logOut, nextPage, checkAuth } from '../../Redux/authReducer'
import { compose } from 'redux'
import { withRouter } from 'react-router-dom'

let HeaderContainer = (props) => {
	return (
		<>
			<Header checkAuth={props.checkAuth}  isAuth={props.isAuth} login={props.login} logOut={props.logOut} nextPage={props.nextPage}/>
		</>
	)
}
let mapStateToProps = (state) => {
	return {
		isAuth: state.auth.isAuth,

	}
}
export default compose(withRouter,connect(mapStateToProps, { login, logOut, nextPage, checkAuth }))(HeaderContainer)
