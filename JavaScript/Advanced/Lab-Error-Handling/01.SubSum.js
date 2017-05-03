/**
 * Created by tangrila on 08-Nov-16.
 */
function subsum(array, startIndex, endIndex) {
	if (array.constructor.name !== "Array")
		return NaN;
	if (startIndex < 0) startIndex = 0;
	if (endIndex > array.length - 1) endIndex = array.length - 1;
	let flag = false;

	for (let i = 0; i < array.length; i++) {
		var number = array[i];
		if (number.constructor.name !== "Number") {
			flag = true;
			break;
		}
	}

	if (flag)
		return NaN;

	let sum = 0;
	for (let i = startIndex; i <= endIndex; i++) {
		sum += array[i];
	}

	return Math.round(sum * 100) / 100;
}
console.log(subsum([10, 20, 30, 40, 50, 60], 3, 300),
subsum([1.1, 2.2, 3.3, 4.4, 5.5], -3, 1),
subsum([10, 'twenty', 30, 40], 0, 2),
subsum([], 1, 2),
subsum('text', 0, 2));
