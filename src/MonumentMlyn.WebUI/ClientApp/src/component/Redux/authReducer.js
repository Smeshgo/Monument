import {authApi} from '../api/api'

let Auth = 'Auth'
let NextPage ='NextPage'

let initialState ={
    isAuth: '',
    nextPage: ''
}

let authReducer = ( state = initialState, action) =>{
    switch(action.type){
        case Auth: {
            return{
                ...state,
                isAuth: action.auth,
            }
        }
        case NextPage: {
            return{
                ...state,
                nextPage: action.next
            }
        }

        default:
            return state
    }
}
export default authReducer

export const authMe = (auth) => ({type: Auth,auth})

export const nextPage = (next) => ({type: NextPage, next })

export const checkAuth = () => async (dispatch) => {
    let response = await authApi.isAuthMe()
}

export const login = (logForm) => async (dispatch) => {
    let response = await authApi.login(logForm)
        dispatch(authMe(true))
        console.log(response)
}

export const logOut = () => async (dispatch) => {
    let response = await authApi.logOut()
        dispatch(authMe(false))
}