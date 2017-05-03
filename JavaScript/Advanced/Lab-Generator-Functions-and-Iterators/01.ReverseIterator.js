/**
 * Created by tangrila on 10-Nov-16.
 */
let iterator = reverseArrayIterator([10, 20, 30]);
while (true) {
	let item = iterator.next();
	if (item.done) break;
	console.log(item.value);
}

function reverseArrayIterator(array) {
	let index = array.length - 1;
	return {
		next: function () {
			if (index >= 0)
				return { value: array[index--], done: false };
			else
				return { done: true };
		}
	}
}