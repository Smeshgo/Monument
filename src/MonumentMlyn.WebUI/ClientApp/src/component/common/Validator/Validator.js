export const required = value => {
    if(value) return undefined;
    return "Заповніть поле"
}