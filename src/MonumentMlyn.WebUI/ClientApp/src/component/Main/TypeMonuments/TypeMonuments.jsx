import React from 'react'
import { NavLink } from 'react-router-dom'
import t from './Monument.module.css'

let TypeMonuments = () => {
	return (
		<div className={t.back}>
			<div className={t.center}>
				<span>Категорії пам'ятників</span>
			</div>
			<div className={t.box}>
				<div className={t.type}>
					<NavLink to='/gallery/1'>
						<img
							src='https://memory.com.ua/img/upload-files/covers/1.jpg'
							alt='одинарні'
						/>
					</NavLink>
					<div>
						<span> Одинарні</span>
					</div>
				</div>
				<div className={t.type}>
					<NavLink to='/gallery/2'>
						<img
							src='https://memory.com.ua/img/upload-files/covers/1.jpg'
							alt='подвійні'
						/>
					</NavLink>
					<div>
						<span>Подвійні</span>
					</div>
				</div>
				<div className={t.type}>
					<NavLink to='/gallery/3'>
						<img
							src='https://memory.com.ua/img/upload-files/covers/1.jpg'
							alt='елітні'
						/>
					</NavLink>
					<div>
						<span>Елітні</span>
					</div>
				</div>
			</div>
		</div>
	)
}

export default TypeMonuments
