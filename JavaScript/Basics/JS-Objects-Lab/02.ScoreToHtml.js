function scoreToHtml([input]) {
	input = JSON.parse(input);
	let html = '<table>\n';
	html += '  <tr><th>name</th><th>score</th></tr>\n';
	for (let obj of input) {
		html += `  <tr><td>${htmlEscape(obj.name)}</td><td>${htmlEscape(obj.score)}</td></tr>\n`;
	};

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
