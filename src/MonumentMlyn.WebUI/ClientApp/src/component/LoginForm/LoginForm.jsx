import React from 'react'
import { Field, reduxForm } from 'redux-form'

import { Input } from '../common/FormHelper/FormControl'
import l from './LoginForm.module.css'
import { required } from '../common/Validator/Validator'

const Login = ({ handleSubmit }) => {
	return (
		<form onSubmit={handleSubmit} >
			<div className={l.title}>
				<label >Вхід</label>
			</div>
			<div className={l.loginPad}>
				<Field className={l.bkgr}
					name='email'
					component={Input}
					type='text'
					placeholder='E-mail'
					validate={[required]}
				/>
			</div>
			<div className={l.loginPad}>
				<Field
					name='password'
					component={Input}
					type='password'
					placeholder='Password'
					validate={[required]}
				/>
			</div>
			<div className={l.loginPad}>
				<Field name='rememberMe' component='input' type='checkbox' />
				<label>Запам'ятати мене</label>
			</div>
			<div className={l.btn}>
				<button  type='submit'>
					Login
				</button>
			</div>
		</form>
	)
}

let LoginReduxForm = reduxForm({
	form: 'adminLogin',
})(Login)

export default LoginReduxForm
