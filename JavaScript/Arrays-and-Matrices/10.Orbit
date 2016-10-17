function orbit(input) {
	let [rows, cols] = input[0].split(' ').map(Number);
	let [tR, tC] = input[1].split(' ').map(Number);
	let matrix = [];
	for (let i = 0; i < rows; i++){
		matrix.push([]);
		for (let j = 0; j < cols; j++){
			matrix[i][j] = Math.max(
				Math.abs(i-tR) + 1, Math.abs(j-tC) + 1
			);
		}
	}
	// Output
	matrix.forEach(x => console.log(x.join(' ')));
}
