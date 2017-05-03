function FirstAndLastKNumbers(array) {
	array = array.map(Number);

	let numbers = array.slice(1);
	let limit = Number(array[0]);
	let first = numbers.slice(0, limit).join(' ');
	let last = numbers.slice( Math.max(numbers.length - limit, 0) ).join(' ');
	console.log(first);
	console.log(last);
}
