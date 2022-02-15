import React, { useState } from 'react'
import Modal from 'react-modal'

import UpdateTextForm from './UpdateTextForm'

let ModalAddArticle = (props) => {
	const [modal, setModal] = useState(false)
	let openModal = () => {
		setModal(true)
	}
	let closeModal = () => {
		setModal(false)
	}
	const customStyles = {
		content: {
			borderRadius: '20px',
			top: '5%',
			left: '5%',
			right: '5%',
			bottom: '5%',
			transform: 'translate(0%, 0%)',
		},
	}
	return (
		<div>
			<div>
                <button onClick={openModal}>Обновити текст</button>
            </div>
			<Modal
				style={customStyles}
				isOpen={modal}
				onRequestClose={closeModal}
				ariaHideApp={false}
			>
				<UpdateTextForm closeModal={closeModal} artId={props.artId} updateText={props.updateText}/>
			</Modal>
		</div>
	)
}

export default ModalAddArticle