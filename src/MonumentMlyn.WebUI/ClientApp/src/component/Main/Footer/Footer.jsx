import React from 'react'

import f from './Footer.module.css'
import telegram from '../../img/header/telegram-2-32.png'
import viber from '../../img/header/viber-4-32.png'
import facebook from '../../img/header/facebook-4-32.png'
import logo from '../../img/header/пмг55 копія.png'
import LoginModal from '../../ModalWindow/LoginModal'
import unlock from '../../img/header/unlock-32.png'
let Footer = (props) => {
	return (
		<div className={f.border}>
			<div className={f.block}>
				<img className={f.logo} src={logo} alt='' />
				<h3>Розробник: stepankurinskij@gmail.com</h3>
				<div className={f.icon}>
					<div>
						<a href='https://t.me/Pmgranit' target="_blank">
							<img src={telegram} alt='telegram' />
						</a>
					</div>
					<div>
						<a href='viber://chat?number=+380979271652' target="_blank"> 
							<img src={viber} alt='viber' />
						</a>
					</div>
					<div>
						<a href='https://www.facebook.com/granit.mlynyska/' target="_blank">
							<img src={facebook} alt='facebook' />
						</a>
					</div>
					<div className={f.logIn}>
						{props.isAuth ? (
							<img src={unlock} alt='unlock' />
						) : (
							<LoginModal login={props.login} />
						)}
					</div>
				</div>
			</div>
		</div>
	)
}

export default Footer
