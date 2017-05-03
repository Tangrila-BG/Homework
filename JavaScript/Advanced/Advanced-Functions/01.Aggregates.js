/**
 * Created by tangrila on 23-Oct-16.
 */
function aggregates(input) {
	console.log('Sum = ' + input.reduce((a, b) => a + b));
	console.log('Min = ' + Math.min.apply(Math, input));
	console.log('Max = ' + Math.max.apply(Math, input));
	console.log('Product = ' + input.reduce((a, b) => a * b));
	console.log('Join = ' + input.join(''));

}
aggregates([
	2,3,10,5
]);
aggregates([
	5, -3, 20, 7, 0.5
]);