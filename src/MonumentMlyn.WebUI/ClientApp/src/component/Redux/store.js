import { applyMiddleware, combineReducers, compose, createStore } from "redux";
import {reducer as formReducer} from 'redux-form'
import thunkMiddleware from 'redux-thunk'
import articleReducer from './articleReducer'
import authReducer from "./authReducer";
import galletyReducer from "./galleryReducer";

let reducers = combineReducers({
    articlePage: articleReducer,
    galleryPage: galletyReducer,
    auth: authReducer,
    form: formReducer
})
const composeEnhancers = window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose
let store = createStore(reducers,composeEnhancers(applyMiddleware(thunkMiddleware)))

export default store