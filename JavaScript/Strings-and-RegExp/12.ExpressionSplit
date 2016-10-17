function expressionSplit([text]) {
	let re = /([^\.,()\t\s;\\])+/g;
	let m = re.exec(text);
	let result = [];
	while (m) {
		result.push(m[0]);
		m = re.exec(text);
	}
	result.forEach(e => console.log(e));
}
