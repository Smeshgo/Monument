import React from "react";
import Cookies from 'js-cookie'

import { NavLink } from "react-router-dom";
import n from './NavBar.module.css'

let NavBar = (props) => {
    return(
            <nav className={n.nav}>
                <div className={n.item}>
                    <NavLink to='/admin/dashbord'>Головна</NavLink>
                </div>
                <div className={n.item}>
                    <NavLink to='/admin/article'>Статті</NavLink>
                </div>
                <div className={n.dropdown}>
					<NavLink to='#' className={n.btn}>
						Галерея
					</NavLink>
					<div className={n.dropdownContent}>
                        <NavLink to='/admin/gallery/1' className={n.btn}>
                        Одинарні
                        </NavLink>
                        <NavLink to='/admin/gallery/2' className={n.btn}>
                        Подвійні
                        </NavLink>
                        <NavLink to='/admin/gallery/3' className={n.btn}>
                            Елітні
                        </NavLink>
					</div>
				</div>
                <div className={n.item}>
                    <NavLink to='#' onClick={()=> {props.nextPage(false); Cookies.remove('nextPage')}}>Сайт</NavLink>
                </div>
            </nav>
        
    )
}
export default NavBar