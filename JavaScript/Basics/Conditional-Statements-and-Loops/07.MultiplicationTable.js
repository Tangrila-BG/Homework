function table([num]) {
	let html = '<table border="1">\n';
	html += "<tr><th>x</th>";

	for (let i = 1; i <= num; i++) {
	    html += `<th>${i}</th>`
	}
	html += "</tr>";

	for (let row = 1; row <= num; row++) {
	    html += `\n<tr><th>${row}</th>`;
		for (let col = 1; col <= num; col++) {
		    html += `<td>${row * col}</td>`;
		}
		html += "</tr>";
	}
	html += "\n</table>";
	return html;
}
