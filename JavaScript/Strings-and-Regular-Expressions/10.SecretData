function secretData(input) {
	input.forEach(function (x) {
		let re = /(\*[A-Z][a-zA-Z]*(?=\s|$))|(\+[0-9-]{10}(?=\s|$))|(\![a-zA-Z\d]+)(?=\s|$)|(_[a-zA-Z\d]+(?=\s|$))/g;
		console.log(x.replace(re,  w => '|'.repeat(w.length)));
	})
}
