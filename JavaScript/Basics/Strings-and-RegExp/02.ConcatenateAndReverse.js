function concatAndReverse(input) {
	let temp = bill.reduce((a, b) => a + b);
	let result = '';
	for (let i = temp.length - 1; i >= 0; i--) {
	    result += temp[i];
	}
	console.log(result);
}
