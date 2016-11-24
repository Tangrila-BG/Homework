/**
 * Created by tangrila on 23-Oct-16.
 */
function fib(input) {
	let fib = (() => {
		let f0 = 0, f1 = 1;
		return () => {
			let oldf0 = f0, oldf1 = f1;
			f0 = oldf1;
			f1 = oldf0 + oldf1;
			return oldf1;
		}
	})();
	let fibNums = [];
	for (let i = 0; i < input; i++) {
	    fibNums.push(fib());
	}
	return fibNums;
};
console.log(fib(15));