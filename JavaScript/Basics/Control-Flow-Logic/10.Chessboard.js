function chessboard([num]) {
	let html = '<div class="chessboard">\n';

	for (var row = 1; row <= num; row++) {
		html += "  <div>\n";
		let color = (row % 2 == 0) ? "white" : "black";

		for (var col = 1; col <= num; col++) {
			html += `    <span class="${color}"></span>\n`;
			color = (color == "white") ? "black" : "white";
		}
		html += "  </div>\n";
	}
	html += "</div>\n";
	return html;
}
