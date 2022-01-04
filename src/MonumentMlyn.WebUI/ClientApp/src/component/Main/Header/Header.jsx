import React from 'react'
import { NavLink } from 'react-router-dom'
import { HashLink as Link } from 'react-router-hash-link'
import h from './Header.module.css'

import unlock from '../../img/header/unlock-32.png'
import telegram from '../../img/header/telegram-2-32.png'
import viber from '../../img/header/viber-4-32.png'
import facebook from '../../img/header/facebook-4-32.png'
import logo from '../../img/header/пмг55 копія.png'
import LoginModal from '../../ModalWindow/LoginModal'
import BurgerMenuContainer from '../BurgerMenu/BurgerMenuContainer'

let Header = ({ isAuth, login, logOut, nextPage, checkAuth, ...props }) => {
	return (
		<div className={h.header}>
			<div className={h.flex}>
				<a href='/main'>
					<img className={h.size} src={logo} alt='' />
				</a>

				<div className={h.headerInfo}>
					<div>
						<p className={h.text1}>
							Тел<a href='tel:+380636785442'> +380636785442 </a>
							<br />
							Тел<a href='tel:+380636785442'> +380636785442 </a>
							<br />
							Вул. Івана Франка 8,
							<br />
							с Млиниська,
							<br />
							Львівська область
						</p>
					</div>
					<div className={h.text}>
						<div className={h.text2}>
							<div>
								<img src={telegram} alt='telegram' />
							</div>
							<div>
								<img src={viber} alt='viber' />
							</div>
							<div>
								<img src={facebook} alt='facebook' />
							</div>
							{isAuth ? (
								<div>
									<img src={unlock} alt='unlock' onClick={() => logOut()} />
								</div>
							) : (
								<LoginModal login={login} checkAuth={checkAuth} />
							)}
						</div>
						<div>
							<span>
								Працюємо:
								<br /> Пн-Пт 9:00-18:00;
								<br /> Сб 9:00-15:00;
							</span>
						</div>
					</div>
				</div>
			</div>
			<div className={h.sp}>
				<div className={h.bl}>
					<img src={logo} alt='' />
				</div>
				<NavLink to='/main' className={h.btn}>
					Головна
				</NavLink>
				<div className={h.dropdown}>
					<NavLink to='#' className={h.btn}>
						Галерея
					</NavLink>
					<div className={h.dropdownContent}>
						<NavLink to='/gallery/1' >
							Одинарні
						</NavLink>
						<NavLink to='/gallery/2' >
							Подвійні
						</NavLink>
						<NavLink to='/gallery/3' >
							Елітні
						</NavLink>
					</div>
				</div>
				<NavLink to='/article' className={h.btn}>
					Статті
				</NavLink>
				<Link to='/main#contacts' className={h.btn}>
					Де нас знайти
				</Link>
				{isAuth && (
					<div className={h.btn} onClick={() => nextPage(true)}>
						Адмін
					</div>
				)}
				<div className={h.hide}>
					<BurgerMenuContainer />
				</div>
			</div>
		</div>
	)
}

export default Header
