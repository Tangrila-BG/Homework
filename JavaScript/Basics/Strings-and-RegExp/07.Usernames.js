function usernames(input) {
	let result = [];
	bill.forEach(function (x) {
		let elements = x.split('@');
		let temp = elements[0] + '.';
		elements = elements[1].split('.');
		elements.forEach(x => temp += x[0]);
		result.push(temp);
	});
	console.log(result.join(', '));
}
