function aggregate(input) {
	let el = bill.map(Number);
	aggregate(el, 0,(a, b) => a + b);
	aggregate(el, 0,(a, b) => a + 1 / b);
	aggregate(el, '',(a, b) => a + b);

	function aggregate(arr, initVal, func) {
		let val = initVal;
		for (let i = 0; i < arr.length; i++) {
		    val = func(val, arr[i]);
		}
		console.log(val);
	}
}
