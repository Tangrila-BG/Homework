function townsToJSON(input) {
	let headers = input[0].split(/\s?\|\s?/g).filter(x => x != '');
	let result = [];
	for (let i = 1; i < input.length; i++) {
	    let temp = input[i].split(/\s?\|\s?/g).filter(x => x != '');
		let obj = {};
		obj[headers[0]] = temp[0];
		obj[headers[1]] = Number(temp[1]);
		obj[headers[2]] = Number(temp[2]);
		result.push(obj);
	}
	console.log(JSON.stringify(result));
}
