function extractUniqueWords(input) {
	let uniqueWords = new Set();
	let re = /[\w]+/g;
	input.forEach(function (x) {
		let matches = x.match(re);
		matches.forEach(x => uniqueWords.add(x.toLowerCase()));
	});
	console.log([...uniqueWords].join(', '));
}
