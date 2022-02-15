import React, { useState } from 'react'

import add from '../../AddNewArticle/AddNewArticle.module.css'
import cancel from '../../../img/cancel-24.png'

let UpdateTextForm = (props) => {
	let [forma, setForma] = useState({ Title: '', Contents: '' })

	let onHandleSubmit = (e) => {
		e.preventDefault()
		props.updateText(props.artId,forma)
	}
	const inputsHandler = (e) => {
		const { name, value } = e.target
		setForma((prevState) => ({
			...prevState,
			[name]: value,
		}))
	}

	return (
		<form>
			<img src={cancel} alt='Вийти' onClick={props.closeModal}/>
			<div className={add.form}>
				<div>
					<input
						className={add.inp}
						type='text'
						name='Title'
						placeholder='Введіть титулку'
						value={forma.Title}
						onChange={inputsHandler}
					/>
				</div>
				<div>
					<textarea
						cols='150'
						rows='30'
						name='Contents'
						placeholder='Введіть текст статті'
						value={forma.Contents}
						onChange={inputsHandler}
					/>
				</div>
				<div>
					<button className={add.btn} onClick={onHandleSubmit}>
						Відправити
					</button>
				</div>
			</div>
		</form>
	)
}
export default UpdateTextForm
