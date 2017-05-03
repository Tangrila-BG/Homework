function squareOfStars([n]) {
	function printStars() {
		console.log("*" + " *".repeat(n - 1));
	}
	for (let i = 1; i <= n; i++) {
	    printStars();
	}
}
