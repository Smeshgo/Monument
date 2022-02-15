import {authApi} from '../api/api'
import Cookies from 'js-cookie'

let Auth = 'Auth'
let Next_Page ='Next_Page'

let initialState ={
    isAuth: '',
    NextPage: ''
}

let authReducer = ( state = initialState, action) =>{
    switch(action.type){
        case Auth: {
            return{
                ...state,
                isAuth: action.auth,
            }
        }
        case Next_Page: {
            return{
                ...state,
                NextPage: action.next
            }
        }
        default:
            return state
    }
}
export default authReducer

export const authMe = (auth) => ({type: Auth,auth})

export const nextPage = (next) => ({type: Next_Page, next })

export const checkAuth = () => async (dispatch) => {
    let response = await authApi.isAuthMe()
}

export const login = (logForm) => async (dispatch) => {
    let response = await authApi.login(logForm)
        dispatch(authMe(true))
        Cookies.set('user',logForm.email)
}

export const logOut = () => async (dispatch) => {
    let response = await authApi.logOut()
        dispatch(authMe(false))
        Cookies.remove('user')
}
