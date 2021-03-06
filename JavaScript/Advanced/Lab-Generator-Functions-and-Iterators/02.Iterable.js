/**
 * Created by tangrila on 10-Nov-16.
 */
for (let item of reverseArrayIterable([10, 20, 30])) {
	console.log(item);
}
function reverseArrayIterable(array) {
	let index = array.length - 1;
	return {
		[Symbol.iterator]: function () {
			return this;
		},
		['next']: function () {
			if (index >= 0)
				return {value: array[index--], done: false};
			else
				return {done: true};
		}
	}
}