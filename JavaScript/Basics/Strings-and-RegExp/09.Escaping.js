function escaping(input) {
	let html = '<ul>\n';
	bill.forEach(x => html += `  <li>${escape(x)}</li>\n`);
	html += '</ul>';
	console.log(html);
	function escape(str) {
		let result = "";
		for (let c of str) {
			if (c == '<') result += '&lt;';
			else if (c == '>') result += '&gt;';
			else if (c == '&') result += '&amp;';
			else if (c == '"') result += '&quot;';
			else result += c;
		}
		return result;
	}
}
