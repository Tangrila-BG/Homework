function processOddNumbers(array) {
	array = array.map(Number);
	let nums = [];
	for (let i = array.length - 1; i >= 0; i--) {
	    if (i % 2 == 1) nums.push(array[i] + array[i]);
	}
	console.log(nums.join(' '));
}
