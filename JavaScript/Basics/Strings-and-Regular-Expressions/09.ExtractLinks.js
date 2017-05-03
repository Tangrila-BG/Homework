function extractLinks(input) {
	let re = /(www\.)([a-zA-Z\d+]+[a-zA-Z\d+ -]*[a-zA-Z\d+]+)([.]{1}[a-z]{2,})+/g;
	let result = [];
	input.forEach(function (x) {
		let ma = re.exec(x);
		while (ma) {
			result.push(ma[0]);
			ma = re.exec(x);
		}
	});
	console.log(result.join('\n'));
}
