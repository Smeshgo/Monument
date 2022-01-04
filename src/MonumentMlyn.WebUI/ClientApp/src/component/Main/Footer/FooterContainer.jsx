import React from 'react'
import { connect } from 'react-redux'

import Footer from './Footer'
import { login } from '../../Redux/authReducer'

let FooterContainer = (props) => {
	return (
		<>
			<Footer  login={props.login} isAuth={props.isAuth}/>
		</>
	)
}

let mapStateToProps = (state) => {
	return {
		isAuth: state.auth.isAuth
	}
}

export default connect(mapStateToProps,{ login })(FooterContainer)
