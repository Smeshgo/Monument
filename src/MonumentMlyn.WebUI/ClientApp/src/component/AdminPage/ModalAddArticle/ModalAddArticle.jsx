import React, { useState } from 'react'
import Modal from 'react-modal'

import PhotoArticleContainer from './PhotoArticle/PhotoArticleContainer'

let ModalAddArticle = (props) => {
	const [modal, setModal] = useState(false)
	
	let onSubmit = (formData) => {
		
		let ids = {articleId: props.artId, photoId: formData}
		
		props.postArticleWithPhoto(ids).then(()=>closeModal)
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
                <button onClick={openModal}>Добавити фото</button>
            </div>
			<Modal
				style={customStyles}
				isOpen={modal}
				onRequestClose={closeModal}
				ariaHideApp={false}
			>
				<PhotoArticleContainer onSubmit={onSubmit}/>
			</Modal>
		</div>
	)
}

export default ModalAddArticle