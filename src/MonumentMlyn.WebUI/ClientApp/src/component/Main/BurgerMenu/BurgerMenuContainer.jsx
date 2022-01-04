import React from 'react'
import { connect } from 'react-redux'

import BurgerMenu from './BurgerMenu'
import { nextPage } from '../../Redux/authReducer'

let BurgerMenuContainer = (props) => {
	return (
		<>
			<BurgerMenu  isAuth={props.isAuth} nextPage={props.nextPage}/>
		</>
	)
}
let mapStateToProps = (state) => {
	return {
		isAuth: state.auth.isAuth,

	}
}
export default connect(mapStateToProps,{ nextPage })(BurgerMenuContainer)