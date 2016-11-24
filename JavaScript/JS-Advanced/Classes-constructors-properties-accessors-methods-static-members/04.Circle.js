/**
 * Created by tangrila on 29-Oct-16.
 */
class Circle {
	constructor(radius) { this.radius = radius; }
	get diameter() { return 2 * this.radius; }
	set diameter(diameter) {
		this.radius = diameter / 2;
	}
	get area() {
		return Math.PI * this.radius * this.radius;
	}
}