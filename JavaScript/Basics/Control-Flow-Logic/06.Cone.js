function calcConeVolumeAndArea(input) {
	let [r, h] = bill.map(Number);
	let slant = Math.sqrt(r * r + h * h);
	let volume = Math.PI * r * r * h / 3;
	let area = Math.PI * r * (r + slant);

	if (h % 1 === 0)
		area = area.toFixed(4);
	else
		area = area.toFixed(3);

	return "volume = " + volume.toFixed(4) + "\narea = " + area;

}
