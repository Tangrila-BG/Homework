/**
 * Created by tangrila on 29-Oct-16.
 */
function Rectangle(width, height, color) {
	return {
		width: this.width = width,
		height: this.height = height,
		color: this.color = color,
		calcArea: function () {
			return width * height;
		}
	}
}

let rectangle = new Rectangle(4, 5, "red");
console.log(rectangle.width);
console.log(rectangle.height);
console.log(rectangle.color);
console.log(rectangle.calcArea());
