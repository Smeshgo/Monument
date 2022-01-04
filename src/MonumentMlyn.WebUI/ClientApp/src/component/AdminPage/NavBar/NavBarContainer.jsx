import React from "react";
import { connect } from "react-redux";

import NavBar from './NavBar'
import {nextPage} from '../../Redux/authReducer'


let  NavBarContainer =(props)=> {
        return(
            <>
                <NavBar nextPage={props.nextPage}/>
            </>
        )
    }
export default connect(null,{nextPage})(NavBarContainer)