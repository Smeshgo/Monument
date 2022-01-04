import s from './FormControl.module.css'

export const FormControl = ({
	input,
	meta: { touched, error },
	children,
	...props
}) => {
	let hasError = touched && error
	return (
		<div className={hasError ? s.border : ''}>
			{children}

			{hasError && <span className={s.error}>{error}</span>}
		</div>
	)
}
export const Input = (props) => {
	let { input, meta, child, ...restProps } = props
	return (
		<FormControl {...props}>
			<input {...input} {...restProps} className={s.field} />
		</FormControl>
	)
}

export const CustomInp = (props) => {
	let { input, meta, child, ...restProps } = props
	return (
		<FormControl {...props}>
			<input {...input} {...restProps} className={s.field} />
		</FormControl>
	)
}
export const CustomTextArea = (props) => {
	let { input, meta, child, ...restProps } = props
	return (
		<FormControl {...props}>
			<textarea {...input} {...restProps} className={s.field} />
		</FormControl>
	)
}
export const CustomSelect = (props) => {
	let { input, meta, child, ...restProps } = props
	return (
		<FormControl {...props}>
			<select {...input} {...restProps} className={s.field} />
		</FormControl>
	)
}
