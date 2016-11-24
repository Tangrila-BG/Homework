/**
 * Created by tangrila on 25-Oct-16.
 */
(function () {
	return {
		add: ([Ax, Ay], [Bx, By]) => {
			return [Ax + Bx, Ay + By];
		},
		multiply: ([Ax, Ay], scalar) => {
			return [Ax * scalar, Ay * scalar];
		},
		length: ([Ax, Ay]) => {
			return Math.sqrt(Ax * Ax + Ay * Ay);
		},
		dot: ([Ax, Ay], [Bx, By]) => {
			return Ax * Bx + Ay * By;
		},
		cross: ([Ax, Ay], [Bx, By]) => {
			return Ax * By - Ay * Bx;
		}
	}
})();
console.log(
	vectorMath.add([1, 1], [1, 0]),
	vectorMath.multiply([3.5, -2], 2),
	vectorMath.length([3, -4]),
	vectorMath.dot([1, 0], [0, -1]),
	vectorMath.cross([3, 7], [1, 0])
);