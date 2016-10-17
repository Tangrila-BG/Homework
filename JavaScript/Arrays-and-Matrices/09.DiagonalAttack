function diagonalAttack(input) {
	let matrix = [];
	input.forEach(row => matrix.push(row.split(' ').map(Number)));
	let mDiagonal = 0;
	let sDiagonal = 0;
	for (let row = 0; row < matrix.length; row++) {
	    mDiagonal += matrix[row][row];
		sDiagonal += matrix[row][matrix.length- 1 - row];
	}

	if (mDiagonal != sDiagonal) {
		let result = '';
		matrix.forEach(row => result += row.join(' ') + '\n');
		return result;
	}

	for (let row = 0; row < matrix.length; row++) {
	    for (let col = 0; col < matrix[row].length; col++) {
		    if (row == col) continue;
		    if (col == matrix.length - 1 - row) continue;
		    matrix[row][col] = mDiagonal;
	    }
	}
	matrix.forEach(row => console.log(row.join(' ')));

}
