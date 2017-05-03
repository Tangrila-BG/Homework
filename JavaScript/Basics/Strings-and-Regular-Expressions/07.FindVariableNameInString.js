function findVarNameInStr(input) {
	let re = /\b(_{1}[a-zA-Z0-9]+)\b/g;
	let result = [];
	let ma = re.exec(input[0])
	while (ma) {
		result.push(ma[0].substring(1));
		ma = re.exec(input[0]);
	}
	console.log(result.join(','));
}
