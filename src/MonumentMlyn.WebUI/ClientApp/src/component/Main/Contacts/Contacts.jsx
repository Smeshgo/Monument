import React from 'react'

import c from './Contacts.module.css'
import address from '../../img/contact/pin-8-32.png'
import contact from '../../img/contact/contacts-32.png'
import email from '../../img/header/email-5-32.png'
import repr from '../../img/contact/conference-32.png'

let Contacts = (props) => {
	return (
		<div className={c.block}>
			<h2>Як нас найти</h2>
			<div className={c.bigflex}>
				<div className={c.flexbox}>
					<div>
						<img src={address} alt='' />
						<div>{"Адрес \n Ivana Franka 8, Mlynys'ka, Lviv Oblast "}</div>
					</div>
					<div>
						<img src={contact} alt='' />
						<div className={c.tel}>Контакти 
							<br />
							<a href='tel:+380979271652'> +380979271652 </a>
							<br />
							<a href='tel:+380668664271'> +380668664271 </a></div>
					</div>
					<div>
						<img src={email} alt='' />
						<div>{'Пошта \nstepankurinskij@gmail.com'}</div>
					</div>

					<div>
						<img src={repr} alt='' />
						<div>Соціальні мережі</div>
						<a className={c.link} href='https://www.facebook.com/granit.mlynyska/' target="_blank">facebook</a>
					</div>
				</div>
				<iframe
					className={c.map}
					src='https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2600.9074366287464!2d24.222785115656254!3d49.31603657933502!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x473a7ba628310eb9%3A0xdfa1cb37de064f03!2z0J_QsNC8J9GP0YLQvdC40LrQuCDQnNC70LjQvdC40YHRjNC60LA!5e0!3m2!1sru!2sua!4v1637244411218!5m2!1sru!2sua'
					loading='lazy'
				></iframe>
			</div>
		</div>
	)
}

export default Contacts
