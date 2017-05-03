function extractIncreasingSubsequence(array) {
	array = array.map(Number);
	let result = [ array[0] ];
	array = array.slice(1);
	let max = Math.max.apply(Math, result);
	array.forEach(function (x) {
		if (max <= x) {
			result.push(x);
			max = x;
		}
	});
	result.forEach(x => console.log(x));
}
