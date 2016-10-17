function JSONsTable(input) {
	let html = '<table>\n';
	input.forEach(function (x) {
		let obj = JSON.parse(x);
		html += '<tr>\n';
		for (let data in obj) {

			html += `<td>${htmlEscape(obj[data])}</td>\n`;
		}
		html += '<tr>\n'
	});
	html += '</table>';
	console.log(html);
	function htmlEscape(text) {
		text = new String(text);
		let map = {
			'"': '&quot;', '&': '&amp;',
			"'": '&#39;', '<': '&lt;', '>': '&gt;'
		};
		return text.replace(/[\"&'<>]/g, c => map[c]);
	}
}
