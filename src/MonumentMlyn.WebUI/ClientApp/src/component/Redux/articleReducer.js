import {articleApi} from '../api/api'

const set_Articles = 'set_Articles'
const set_One_Article = 'set_One_Article'
const set_Articles_Photo = 'set_Article_Photo'
const set_This_Page = 'set_This_Page'
const count_Articles_Photos='count_Articles_Photos'

let initialState = {
    articles: [],
    oneArticle: {
        photos: []
    },
    articlesPhoto: [],
    pageNumbers: 8,
	countArticlesPhoto: 0,
	thisPage: 1,
 }

let articleReducer = ( state = initialState, action) =>{
    switch(action.type){
        case set_Articles: {
            return{
                ...state,
                articles: action.article
            }
        }
        case set_One_Article:{
            return{
                ...state,
                oneArticle: action.oneArticle
            }
        }
        case set_Articles_Photo:{
            return{
                ...state,
                articlesPhoto: action.articlesPhoto,
            }
        }
        case set_This_Page:{
            return{
                ...state,
                thisPage: action.thisPage,
            }
        }
        case count_Articles_Photos:{
            return{
                ...state,
                countArticlesPhoto: action.countArticlesPhoto,
            }
        }
        default:
            return state
    }
}
export default articleReducer

export const setArticles = (article) =>({type:set_Articles, article})
export const setOneArticle = (oneArticle) =>({type: set_One_Article, oneArticle})
export const setThisPage = (thisPage) => ({type:set_This_Page, thisPage})
export const setArticlePhoto = (articlesPhoto) => ({type: set_Articles_Photo, articlesPhoto})
export const setCountArticlesPhoto = (countArticlesPhoto) => ({type: count_Articles_Photos,countArticlesPhoto})

export const getArticles = () => async (dispatch) => {
	let response = await articleApi.getArticle()
    console.log(response)
	dispatch(setArticles(response.data))
    
}

export const getOneArticle = (articleId) => async (dispatch) =>{
    let response = await articleApi.getArticleById(articleId)
    dispatch(setOneArticle(response.data[0]))
}

export const postArticleWithoutPhoto = (art) => async (dispatch) => {
    await articleApi.postArticleWithoutPhoto(art)
    alert('Стаття добавлена')
}
export const getAllPhotoForArticle = (thisPage,pageNumbers) => async (dispatch) => {
    let response = await articleApi.getPhotoForArticle(thisPage,pageNumbers)
    dispatch(setArticlePhoto(response.data))
    dispatch(setCountArticlesPhoto(JSON.parse(response.headers['x-pagination']).TotalCount))
}
export const pageChanged = (thisPage,pageNumbers) => async (dispatch) => {
	dispatch(setThisPage(thisPage))
	let response = await articleApi.getPhotoForArticle(thisPage,pageNumbers)
	dispatch(setArticlePhoto(response.data))
}
export const postArticleWithPhoto = (twoId) => async (dispatch) => {
    await articleApi.postArticleWithPhoto(twoId)
    dispatch(getOneArticle(twoId.articleId))
}
export const deleteArticlePhoto = (articleId,photoId) => async (dispatch) => {
    await articleApi.deleteArticlePhoto(articleId,photoId)
    dispatch(getOneArticle(articleId))
}
export const deleteArticle = (articleId) => async (dispatch) =>{
    await articleApi.deleteArticle(articleId)
    dispatch(getArticles())
}
export const updateText = (id,articleContent) => async (dispatch) =>{
    await articleApi.updateText(id,articleContent)
    dispatch(getOneArticle(id))
}