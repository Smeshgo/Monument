import React, { useState } from 'react'
import Modal from 'react-modal'

import LoginReduxForm from '../LoginForm/LoginForm'
import lock from '../img/header/замок.png'
import l from './LoginModal.module.css'


let LoginModal = (props) => {
	
	const [modal, setModal] = useState(false)

	let onSubmit = (formData) => {
		let data = {...formData,returnUrl: 'https://localhost:44329/'}
		props.login(JSON.stringify(data))
	}

	let openModal = () => {
		setModal(true)
	}

	let closeModal = () => {
		setModal(false)
	}

	const customStyles = {
		content: {
			borderRadius: '20px',
			top: '30%',
			left: '45%',
			right: '45%',
			bottom: '25%',
			width: '35%',
			transform: 'translate(-40%, -10%)',
			maxHight:'100%'
		},
	}
	return (
		<div>
			<img src={lock} alt='lock' onClick={openModal} className={l.login} />
			<Modal
				style={customStyles}
				isOpen={modal}
				onRequestClose={closeModal}
				ariaHideApp={false}
			>
				<LoginReduxForm onSubmit={onSubmit} closeModal={closeModal} />
			</Modal>
		</div>
	)
}

export default LoginModal
