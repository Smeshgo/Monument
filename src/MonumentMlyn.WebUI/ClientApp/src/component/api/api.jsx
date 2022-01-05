import * as axios from 'axios'
export const instance = axios.create({
	baseURL: 'https://localhost:44329/api/',
	headers: { 
		"Content-Type": "application/json",  
	  }
})

export const articleApi = {
	getArticle(){
		return instance.get(`article/many`,)
	},
	getArticleById(articleId){
		return instance.get(`article/many/` + articleId)
	},
	postArticleWithoutPhoto(art){
		return instance.post(`Article`, art)
	},
	getPhotoForArticle(pageNumber = 1, pageSize = 8){
		return instance.get(`Photo/category?category=4&pageNumber=${pageNumber}&pageSize=${pageSize}`)
	},
	postArticleWithPhoto(twoId){
		return instance.post(`Article/many`,twoId)
	},
	deleteArticlePhoto(articleId,photoId){
		debugger
		return instance.delete(`Article/many/${articleId}?photoId=${photoId}`)
	},
	deleteArticle(articleId){
		return instance.delete(`Article/`+ articleId)
	}
}

export const authApi = {
	isAuthMe(){
		return instance.get(`Photo/autorize`)
	},
	login(logForm){
		return instance.post(`Authorization/login/`, logForm)
	},
	logOut(){
		return instance.post(`Authorization/Logout`)
	}
}
export const galleryApi = {
	getAllPhoto(category,pageNumber = 1, pageSize = 8){
		return instance.get(`Photo/category?category=${category}&pageNumber=${pageNumber}&pageSize=${pageSize}`)
	},
	getPhotoById(photoId) {
		return instance.get(`Photo/` + photoId)
	},
	sendPhoto(name,type,formData){
		return instance.post(`Photo?name=${name}&category=${type}`,formData)
	},
	deletePhoto(id){
		return instance.delete(`Photo/`+ id)
	}
}
