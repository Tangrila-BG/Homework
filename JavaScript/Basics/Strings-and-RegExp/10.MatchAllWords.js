function matchAllWords([text]) {
	let re = /\w+/g;
	let m;
	let result = [];
	do {
		m = re.exec(text);
		if (m) result.push(m[0]);
	} while (m);
	console.log(result.join('|'));
}
