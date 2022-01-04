import React from 'react'
import { connect } from 'react-redux'

import CreatePhoto from './CreatePhoto'
import { sendTwophoto } from '../../Redux/galleryReducer'

let CreatePhotoContainer = (props) => {
	return (
		<>
			<CreatePhoto  sendTwophoto={props.sendTwophoto}/>
		</>
	)
}

export default connect(null,{ sendTwophoto })(CreatePhotoContainer)