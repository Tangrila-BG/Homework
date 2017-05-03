function TriangleOfStars([n]) {
	for (let row = 1; row <= n; row++)
		console.log("*".repeat(row));
	for (let row = n-1; row >= 1; row--)
		console.log("*".repeat(row));
}
