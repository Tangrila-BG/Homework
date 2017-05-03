function sumByTown(input) {
	let obj = {};
	for (let i = 0; i < input.length; i += 2) {
	    if (obj[`${input[i]}`] == undefined)
		    obj[`${input[i]}`] = Number(input[i + 1]);
	    else
		    obj[`${input[i]}`] += Number(input[i + 1]);

	}
	console.log(JSON.stringify(obj));
}
