/**
 * Created by tangrila on 02-Nov-16.
 */
function classHierarchy() {
	class Figure {
		constructor() {
			if (new.target === Figure) {
				throw new TypeError(`Cannot construct ${this.className} instances directly`);
			}
		}

		get className() {
			return this.constructor.name;
		}
	}

	class Circle extends Figure {
		constructor(radius) {
			super();
			this.radius = radius;
		}

		get area() {
			return Math.PI * this.radius * this.radius;
		}

		toString() {
			return `${this.className} - radius: ${this.radius}`;
		}
	}

	class Rectangle extends Figure {
		constructor(width, height) {
			super();
			this.width = width;
			this.height = height;
		}

		get area() {
			return this.width * this.height;
		}

		toString() {
			return `${this.className} - width: ${this.width}, height: ${this.height}`;
		}
	}

	return {
		Figure,
		Circle,
		Rectangle
	}
}

//let f = new Figure();       //Error
let c = new Circle(5);
console.log(c.area);        //78.53981633974483
console.log(c.toString());  //Circle - radius: 5
let r = new Rectangle(3,4);
console.log(r.area);        //12
console.log(r.toString());
