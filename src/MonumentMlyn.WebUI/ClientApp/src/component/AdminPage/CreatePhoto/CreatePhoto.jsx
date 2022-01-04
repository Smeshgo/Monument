import React, { useState } from 'react'

import c from './CreatePhoto.module.css'

let CreatePhoto = (props) => {
	const [file, setFile ]= useState({imgFull: {}, imgMini: {}});
	let [name, setName] = useState('')
	let [type, setType] = useState('')

	let onHandleSubmit = (e) => {
		e.preventDefault()
		console.log(file)
		var formData = new FormData();
		for (var key in file) {
			console.log(key, file[key]);
			formData.append(key, file[key]);
		}
		props.sendTwophoto(name,type, formData)
	}
	return (
		<div>
			<form className={c.photoForm}>
				<div>
					<input
						type='file'
						name='imgFull'
						onChange={e=> {
							setFile({...file, imgFull: e.target.files[0]})
						}}
					/>
				</div>
				<div>
					<input
						type='file'
						name='imgMini'
						onChange={e=> {
							setFile({...file, imgMini: e.target.files[0]})
						}}
					/>
				</div>
				<div>
					<input
						type='text'
						placeholder='назва картинки'
						value={name}
						onChange={(e) => setName(e.target.value)}
					/>
				</div>
				<div>
					<select value={type} onChange={(e) => setType(e.target.value)}>
						<option>Категорія</option>
						<option value='1'>Одинарні </option>
						<option value='2'>Подвійні</option>
						<option value='3'>Елітні</option>
						<option value='4'>Стаття </option>
					</select>
				</div>

				<div>
					<button className={c.btn} onClick={onHandleSubmit}>
						Зберегти
					</button>
				</div>
			</form>
		</div>
	)
}

export default CreatePhoto
