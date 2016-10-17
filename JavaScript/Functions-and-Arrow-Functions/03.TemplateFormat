function template(input) {
	let xml = '<?xml version="1.0" encoding="UTF-8"?>';
	xml += '\n<quiz>';
	for (let row = 0; row < bill.length; row += 2) {
		let question = bill[row];
		let answer = bill[row + 1];
		xml += '\n  <question>';
		xml += `\n    ${question}`;
		xml += '\n  </question>';
		xml += '\n  <answer>';
		xml += `\n    ${answer}`;
		xml += '\n  </answer>';
	}
	xml += '\n</quiz>';
	console.log(xml);
}
