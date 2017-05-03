function countWordsInAText([text]) {
	let obj = {};
	let re = /[\w]+/g;
	let ma = re.exec(text);
	while (ma) {
		if (obj[ma[0]] == undefined) 
			obj[ma[0]] = 1;
		else
			obj[ma[0]]++;
		ma = re.exec(text);
	}
	console.log(JSON.stringify(obj));
}
