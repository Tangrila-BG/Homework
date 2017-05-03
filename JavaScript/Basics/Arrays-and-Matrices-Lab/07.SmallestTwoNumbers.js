function smallestTwoNums(array) {
	array = array.map(Number);
	array.sort((a, b) => a-b);
	console.log(array.slice(0, 2).join(' '));
}
