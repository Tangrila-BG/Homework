function JSONtoHTMLTable(input) {
	input = JSON.parse(input);

	// Init table
	let html = '<table>\n';

	// Headers
	let headers = Object.keys(input[0]);
	html += '  <tr>';
	for (let header of headers)
		html += `<th>${header}</th>`;
	html += '</tr>\n';

	// Body
	for (let obj of input) {
		html += '  <tr>';
		for (let header of headers) {
			html += `<td>${htmlEscape(obj[header])}</td>`;
		}
		html += '</tr>\n';
	}

	// Close table
	html += '</table>';
	// Output
	console.log(html);
	// Helpers
	function htmlEscape(text) {
		text = new String(text);
		let map = {
			'"': '&quot;', '&': '&amp;',
			"'": '&#39;', '<': '&lt;', '>': '&gt;'
		};
		return text.replace(/[\"&'<>]/g, c => map[c]);
	}
}
