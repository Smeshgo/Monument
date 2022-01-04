import React from 'react'

import head from './Header.module.css'
import logo from '../../img/іконка.png'

let Header = (props) => {
	return (
		<div className={head.header}>
			<div className={head.logoAdmin}>
				<img src={logo} alt='logo' />
				<p>Пам'ятники млиниська</p>
			</div>
			<div className={head.blockBtn}>
				<button onClick={()=> props.logOut()} >Logout</button>
			</div>
		</div>
	)
}

export default Header
