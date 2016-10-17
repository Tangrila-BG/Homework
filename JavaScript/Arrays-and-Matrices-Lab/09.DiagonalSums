function diagonalSums(matrix) {
	let mainDiagonal = 0;
	let secondaryDiagonal = 0;
	matrix = matrix.map(row => row.split(' ').map(Number));

	for (let row = 0; row < matrix.length; row++) {
	    mainDiagonal += matrix[row][row];
		secondaryDiagonal += matrix[row][matrix.length - 1 - row];
	}
	console.log(mainDiagonal + ' ' + secondaryDiagonal);
}
