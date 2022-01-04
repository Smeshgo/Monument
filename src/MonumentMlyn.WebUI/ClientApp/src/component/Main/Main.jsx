import React, { useState } from 'react'
import m from './Main.module.css'
import { NavLink } from 'react-router-dom'

import Contacts from './Contacts/Contacts'
import TypeMonuments from './TypeMonuments/TypeMonuments'
import Slider from './Slider/Slider'

let Main = (props) => {
	return (
		<div>
			<div className={m.textOnPhoto}>
				<Slider />
				<div className={m.textOnPhoto1}>
					<h2>Про нас</h2>
					<span>
						Нам Дуже приємно, що Ви завітали на нашу сторінку. Це вказує на те,
						що ви потребуєтеся у наших послугах. Досвід не дається нікому
						відразу, а накопичується з роками. Тому, ми вважаємо, що вислів “від
						діда до батька, від батька до сина” є запорукою успіху. Основним
						видом діяльності нашої родинної майстерні є виготовлення
						надмогильних пам’ятників. Проте, Ви також можете замовити сходи,
						підвіконня, стільниці (кухонні,ванні) та інші речі, які можна
						виконати з граніту. Виготовлення пам’ятників включає весь комплекс
						послуг - від замовлення – до його встановлення на цвинтарі.
					</span>
					<div>
						<button className={m.btn}>
							<NavLink to='/article' className={m.postLink}>
								Дізнатись більше
							</NavLink>
						</button>
					</div>
				</div>
			</div>

			<TypeMonuments />
			<div id={'contacts'}>
				<Contacts />
			</div>
		</div>
	)
}

export default Main
