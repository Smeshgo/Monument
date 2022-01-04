import React, { useState } from 'react'
import Lightbox from 'react-image-lightbox'
import 'react-image-lightbox/style.css'
import Paginator from '../../common/Pagination/Pagination'
import { NavLink } from 'react-router-dom'
import ag from './AdminGalery.module.css'
import plus from '../../img/plus.png'
import trashbox from '../../img/trash-5-32.png'

let AdminGalery = ({
	photoIndex,
	allPhoto,
	setPhotoIndex,
	getPhoto,
	photo,
	deleteThisPhoto,
	...props
}) => {
	const [isOpen, setIsOpen] = useState(false)
	let Click = (index) => {
		setIsOpen(true)
		setPhotoIndex(index)
	}

	return (
		<div className={ag.gallery}>
			<div className={ag.position}>
				<div className={ag.blockAdd}>
					<NavLink to='/admin/createPhoto'>
						<img src={plus} alt='add' />
					</NavLink>
				</div>
				{allPhoto.map((item, index) => (
					<div key={index} className={ag.text}>
						<img
							src={`data:image;base64,${item.minyPhoto}`}
							alt='gallery-photo'
							onClick={() => Click(index)}
						/>
						<div className={ag.text1}>
							<span>{item.name}</span>
						</div>
						<div className={ag.trash}>
							<img src={trashbox} alt='delete' onClick={()=> {deleteThisPhoto(item.photoId)}}/>
						</div>
					</div>
				))}
				{isOpen && (
					<Lightbox
						mainSrc={
							photo || `data:image;base64,${allPhoto[photoIndex].minyPhoto}`
						}
						nextSrc={`data:image;base64,${
							allPhoto[(photoIndex + 1) % allPhoto.length]
						}`}
						prevSrc={`data:image;base64,${
							allPhoto[(photoIndex + allPhoto.length - 1) % allPhoto.length]
						}`}
						onCloseRequest={() => setIsOpen(false)}
						onMovePrevRequest={() =>
							setPhotoIndex(
								(photoIndex + allPhoto.length - 1) % allPhoto.length
							)
						}
						onMoveNextRequest={() =>
							setPhotoIndex((photoIndex + 1) % allPhoto.length)
						}
						imageTitle={allPhoto[photoIndex].name}
					/>
				)}
			</div>
			<Paginator
				pageSize={props.pageSize}
				totalPhotoCount={props.totalPhotoCount}
				currentPage={props.currentPage}
				onPageChanged={props.onPageChanged}
			/>
		</div>
	)
}
export default AdminGalery
