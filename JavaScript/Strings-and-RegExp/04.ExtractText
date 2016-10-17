function extractText([str]) {
	let result = [];
	let left = str.indexOf('(');
	let right = -1;
	while (true) {
		left = str.indexOf('(', right+1);
		if (left == -1) break;
		right = str.indexOf(')', left+1);
		if (right == -1) break;
		result.push(str.substring(left + 1, right));
	}
	console.log(result.join(', '));
}
