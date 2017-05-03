/**
 * Created by tangrila on 10-Nov-16.
 */
function* reverseArrayGenerator(array) {
	for (let i = array.length - 1; i >= 0; i--) {
		yield array[i];
	}
}
for (let i of reverseArrayGenerator([20, 30, 50])) {
	console.log(i);
}