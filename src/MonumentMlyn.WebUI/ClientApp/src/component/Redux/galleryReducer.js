import {galleryApi} from '../api/api'

const set_Photos = 'set_Photos'
const set_Photo = 'set_Photo'
const set_Current_Page ='set_Current_Page'
const set_Total_Photo_Count ='set_Total_Photo_Count'
const set_Category = 'set_Category'
const set_PhotoIndex ='set_PhotoIndex'

let initialState ={
    allPhoto: [	],
	photo:'',
	photoIndex: 1,
    pageSize: 8,
	totalPhotoCount: 0 ,
	currentPage: 1,
    category: 1
}

let galletyReducer = ( state = initialState, action) =>{
    switch(action.type){
        case set_Photos: {
            return{
                ...state,
                allPhoto: action.allPhoto,
            }
        }
        case set_Current_Page: {
			return {
				...state,
				currentPage: action.currentPage,
			}
		}
        case set_Category: {
			return {
				...state,
				category: action.category,
			}
		}
		case set_PhotoIndex: {
			return {
				...state,
				photoIndex: action.photoIndex,
			}
		}
		case set_Total_Photo_Count: {
			return {
				...state,
				totalPhotoCount: action.totalPhotoCount,
			}
		}
		case set_Photo: {
			return {
				...state,
				photo: `data:image;base64,${action.src}`,
			}
		}
        default:
            return state
    }
}
export default galletyReducer

export const setPhotos = (allPhoto) =>({type:set_Photos, allPhoto})

export const setPhotoIndex = (photoIndex) =>({type:set_PhotoIndex, photoIndex})

export const setPhoto = (src) =>({type:set_Photo, src})

export const setCurrentPage = (currentPage) => ({
	type: set_Current_Page,
	currentPage,
})

export const setCategory = (category) => ({type:set_Category, category})

export const setTotalPhotosCount = (totalPhotoCount) => ({
	type: set_Total_Photo_Count,
	totalPhotoCount,
})

export const getPhotos = (category,pageNumber,pageSize) => async (dispatch) => {
	let response = await galleryApi.getAllPhoto(category,pageNumber,pageSize)
	dispatch(setPhotos(response.data))
    dispatch(setCategory(category))
    dispatch(setTotalPhotosCount(JSON.parse(response.headers['x-pagination']).TotalCount))
}

export const getPhoto = (photoId) => async (dispatch)=> {
	let response = await galleryApi.getPhotoById(photoId)
	dispatch(setPhoto(response.data.fullPhoto))
}

export const getPageChanged = (category,pageNumber,pageSize) => async (dispatch) => {
	dispatch(setCurrentPage(pageNumber))
	let response = await galleryApi.getAllPhoto(category,pageNumber,pageSize)
	dispatch(setPhotos(response.data))
}

export const sendTwophoto = (name,type,formData) => async(dispatch) =>{
	let response = await galleryApi.sendPhoto(name,type,formData)	
	alert('Успішно')
}

export const deleteThisPhoto = (id) => async (dispatch) => {
	let respose = await galleryApi.deletePhoto(id)
	alert('Успішно')
}