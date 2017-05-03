function areaAndPerimeter([a, b]) {
	a = Number(a);
	b = Number(b);
	let area = Math.round(a * b * 100) / 100;
	let perimeter = Math.round(2*(a+b) * 100) / 100;

	return area + "\n" + perimeter;
}
