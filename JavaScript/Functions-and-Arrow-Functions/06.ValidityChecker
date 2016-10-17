function validityChecker(input) {
	bill = bill.map(Number);
	let x1 = bill[0];
	let y1 = bill[1];
	let x2 = bill[2];
	let y2 = bill[3];

	let distance = function (x1, y1, x2, y2){
		return Math.sqrt(Math.pow(x2 - x1, 2) + Math.pow(y2 - y1, 2))
	};

	let valid = function (num) { return num % 1 === 0};

	let pointAToZero = valid(distance(x1, y1, 0, 0))
		? 'valid' : 'invalid';
	let pointBtoZero = valid(distance(x2, y2, 0, 0))
		? 'valid' : 'invalid';
	let PointAToPointB = valid(distance(x1, y1, x2 ,y2))
		? 'valid' : 'invalid';

	console.log(`{${x1}, ${y1}} to {0, 0} is ${pointAToZero}`);
	console.log(`{${x2}, ${y2}} to {0, 0} is ${pointBtoZero}`);
	console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is ${PointAToPointB}`);
}
