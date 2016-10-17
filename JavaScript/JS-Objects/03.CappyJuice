function cappyJuice(input) {
	let produce = new Map();
	let stock = new Map ();
	input.forEach(function (x) {
		let [juice, quantity] = x.split(/\s+\=\>\s+/g);
		quantity = Number(quantity);
		if (!stock.has(juice))
			stock.set(juice, quantity);
		else
			stock.set(juice, stock.get(juice) + quantity);

		if (stock.get(juice) >= 1000) {
			if (!produce.has(juice))
				produce.set(juice,  Math.floor(stock.get(juice) / 1000));
			else
				produce.set(juice, produce.get(juice) + Math.floor(stock.get(juice) / 1000));

			stock.set(juice, stock.get(juice) - Math.floor(stock.get(juice) / 1000) * 1000);
		}
	});
	produce.forEach((amount, product) => console.log(`${product} => ${amount}`));
}
