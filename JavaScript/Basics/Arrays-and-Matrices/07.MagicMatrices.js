function magicMatrices(array) {
	array = array.map(row => row.split(' ').map(Number));
	let commonSum = Number(array[0].reduce((a, b) => a + b));
	let i = 0;
	for (let r in array) {
		// Checks rows sum
		let row = array[r];
		let check2 = row.reduce((a, b) => a+b);
		if (commonSum != check2) return 'false';

		// Checks columns sum
		let column = array.map(row => row[i]);
		column = column.map(Number);
		let check = column.reduce((a, b) => a+b);
		if (commonSum != check)
			return 'false';
		i++;
	}
	return 'true';
}
