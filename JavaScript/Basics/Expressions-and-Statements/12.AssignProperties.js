function assignProps(input) {
	let object = {};
	for (var i = 0; i <= bill.length / 2 + 1; i++) {
		let property = bill[i];
		let value = bill[i + 1];
		object[property] = value;
		i++;
	}
	return object;
}
