function captureTheNumbers(input) {
	let result = [];
	let re = /[\d+]+/g;
	input.forEach(function (x) {
		let ma = re.exec(x);
		while (ma) {
			result.push(ma[0]);
			ma = re.exec(x);
		}
	})
	console.log(result.join(' '));
}
