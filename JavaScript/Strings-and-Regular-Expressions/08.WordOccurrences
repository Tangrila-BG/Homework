function wordOccurrences(input) {
	let target = input[1];
	let count = 0;
	let re = new RegExp("\\b" + target + "\\b", 'gi');
	let ma = re.exec(input[0]);
	while (ma) {
		count++;
		ma = re.exec(input[0]);
	}
	console.log(count);
}
