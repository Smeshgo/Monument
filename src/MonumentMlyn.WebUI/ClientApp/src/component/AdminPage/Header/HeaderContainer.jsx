import React from 'react'
import { connect } from 'react-redux'

import Header from './Header'
import { logOut } from '../../Redux/authReducer'

let HeaderContainer = (props) => {
	return (
		<>
			<Header  isAuth={props.isAuth} login={props.login} logOut={props.logOut}/>
		</>
	)
}
let mapStateToProps = (state) => {
	return {
		isAuth: state.auth.isAuth
	}
}
export default connect(mapStateToProps, { logOut })(HeaderContainer)