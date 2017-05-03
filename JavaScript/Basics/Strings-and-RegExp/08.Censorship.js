function censorship(input) {
	RegExp.escape = function(text) {
		return text.replace(/[-[\]{}()*+?.,\\^$|#\s]/g, "\\$&");
	};
	let text = bill[0];
	let words = bill.slice(1).map(RegExp.escape).join('|');
	let regex = new RegExp(words, 'g');
	text = text.replace(regex, w => '-'.repeat(w.length));
	console.log(text);
}
