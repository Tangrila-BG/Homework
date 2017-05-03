function distanceIn3D(input) {
	bill = bill.map(Number);
	let point = function Point([x, y, z]) {
		let point = { X: x, Y: y, Z: z };
		return point;
	};
	let point1 = point(bill.slice(0, 3));
	let point2 = point(bill.slice(3));
	let distance = Math.sqrt(
		Math.pow(point1.X - point2.X, 2) +
		Math.pow(point1.Y - point2.Y, 2) +
		Math.pow(point1.Z - point2.Z, 2)
	);
	return distance;
}
