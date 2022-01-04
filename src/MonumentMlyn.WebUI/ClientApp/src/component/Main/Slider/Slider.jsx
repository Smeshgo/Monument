import React, { useState, useEffect, useRef } from 'react'

import photos from '../../img/фото.jpg'
import './Slider.css'
let Slider = () => {
	const img = [
		<img key={photos} src={photos} />,
		<img key={photos} src={photos} />,
		<img key={photos} src={photos} />,
		<img key={photos} src={photos} />,
		<img key={photos} src={photos} />,
	]
	const [index, setIndex] = useState(0)
	const timeoutRef = useRef(null)
	function resetTimeout() {
		if (timeoutRef.current) {
			clearTimeout(timeoutRef.current)
		}
	}
	useEffect(() => {
		resetTimeout()
		timeoutRef.current = setTimeout(
			() =>
				setIndex((prevIndex) =>
					prevIndex === img.length - 1 ? 0 : prevIndex + 1
				),
			8000
		)
		return () => {
			resetTimeout()
		}
	}, [index])
	return (
		<div className='slideshow'>
			<div
				className='slideshowSlider'
				style={{ transform: `translate3d(${-index * 100}%, 0, 0)` }}
			>
				{img.map((image, index) => (
					<div className='slide' key={index}>
						{image}
					</div>
				))}
			</div>

		</div>
	)
}
export default Slider
