function equalNeighbors(matrix) {
	matrix = matrix.map(row => row.split(' '));
	let equalNum = 0;
	for (let row = 0; row < matrix.length - 1; row++) {
	    for (let col = 0; col < matrix[row].length; col++) {
	        if (matrix[row][col] == matrix[row + 1][col]) {
		        equalNum++;
	        }
		    if (matrix[row][col] == matrix[row][col + 1] ||
		        row == matrix.length - 2 &&
		        matrix[row + 1][col] == matrix[row + 1][col + 1]) {
			    equalNum++;
		    }
	    }
	}
	console.log(equalNum);
}
