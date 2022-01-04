import React from 'react'

import './BurgerMenu.css'

let BurgerMenu = ({isAuth, nextPage}) => {
	return (
		<nav className='header'>
			<input className='menu-btn' type='checkbox' id='menu-btn' />
			<label className='menu-icon' htmlFor='menu-btn'>
				<span className='navicon'></span>
			</label>
			<ul className='menu'>
				<li className='list'>
					<a href='/main'>Головна</a>
				</li>
				<li className='list'>
					<a href='#'>Галерея</a>
				</li>
				<li className='bckgcol list'>
					<a className='pad-left' href='/gallery/1'>Одинарні</a>
				</li>
				<li className='bckgcol list'>
					<a className='pad-left2' href='/gallery/2'>Подвійні</a>
				</li>
				<li className='bckgcol list'>
					<a className='pad-left3' href='/gallery/2'>Елітні</a>
				</li>
				<li>
					<a href='/article'>Статті</a>
				</li>
				<li>
					<a href='/main#contacts'>Де нас знайти</a>
				</li>
				{isAuth && 
					<li onClick={()=> nextPage(true)}>
						<a href='#'>Адмін</a>
					</li>}
			</ul>
		</nav>
	)
}

export default BurgerMenu
