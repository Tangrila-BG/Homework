function negativeAndPositiveNumbers(array) {
	array = array.map(Number);
	let negative = [];
	let positive = [];

	for (let i = 0; i < array.length; i++) {
		let j = array.length - i - 1;
		if (array[i] >= 0)
			positive.push(array[i]);
		if (array[j] < 0)
			negative.push(array[j]);
	}

	negative.forEach(x => console.log(x));
	positive.forEach(x => console.log(x));
}
