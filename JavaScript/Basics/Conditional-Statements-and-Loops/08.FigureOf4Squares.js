function fourSquares([n]) {
	n = Number(n);
	let rows = n;
	if (n % 2 == 0) rows -= 1;
	let dash = "-".repeat(n - 2);
	let space = " ".repeat(n - 2);
	for (let i = 1; i <= rows; i++) {
	    if (i == Math.round(rows / 2) || i == 1 || i == rows)
	    	console.log(`+${dash}+${dash}+`);
		else
			console.log(`|${space}|${space}|`);
	}
}
