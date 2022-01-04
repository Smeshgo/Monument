import React, {useState} from 'react'
import Lightbox from 'react-image-lightbox'
import 'react-image-lightbox/style.css'
import Paginator from '../../common/Pagination/Pagination'
import g from './Galery.module.css'

let  Gallery = ({photoIndex, allPhoto, setPhotoIndex,getPhoto,photo, ...props })=> {
		const [isOpen, setIsOpen] = useState(false);
		let Click =(index)=>{
			setIsOpen(true)
			setPhotoIndex(index)
		}
		
		return (
			<div className={g.gallery}>
				<div className={g.position}>
					{allPhoto.map((item, index) => (
						<div key={index} className={g.text}>
							<img
								src={`data:image;base64,${item.minyPhoto}`}
								alt='gallery-photo'
								onClick={() =>
									Click(index)
								}
							/>
							<div className={g.text1}>
								<span>{item.name}</span>
							</div>
						</div>
					))}
					{isOpen && (
						<Lightbox
							mainSrc={photo|| `data:image;base64,${allPhoto[photoIndex].minyPhoto}`}
							nextSrc={`data:image;base64,${allPhoto[(photoIndex + 1) % allPhoto.length]}`}
							prevSrc={`data:image;base64,${allPhoto[(photoIndex + allPhoto.length - 1) % allPhoto.length]}`}
							onCloseRequest={() => setIsOpen(false)}
							onMovePrevRequest={() =>
								setPhotoIndex((photoIndex + allPhoto.length - 1) % allPhoto.length)
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

export default Gallery
