function DNA([n]) {
	let sequence = Array.from("ATCGTTAGGG");

	let stars = 0;
	let dashes = 0;

	for (let row = 1, flow = 0, i = 0; row <= n; row++, i += 2, flow++) {
		if (flow == 5) { flow = 1; }
		if (flow == 0 || flow == 4) { stars = 2; dashes = 0;}
		if (flow == 1 || flow == 3) { stars = 1; dashes = 2;}
		if (flow == 2) { stars = 0; dashes = 4;}

		let letter1 = sequence[i % sequence.length];
		let letter2 = sequence[(i + 1) % sequence.length];
		let star = "*".repeat(stars);
		let dash = "-".repeat(dashes);

		console.log(`${star}${letter1}${dash}${letter2}${star}`);
	}
}
