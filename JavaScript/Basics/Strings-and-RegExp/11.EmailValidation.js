function emailValidation(email) {
	var re = /^([a-zA-Z0-9]+)@([a-z]+\.[a-z]+)/g;
	return re.test(email) ? 'Valid' : 'Invalid';
}
