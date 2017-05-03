function storeCatalogue(input) {
	let catalogue = new Map();
	input.forEach(function (x) {
		let [product, price] = x.split(/\s+\:\s+/g);
		let capital = product[0];
		price = Number(price);
		if (!catalogue.has(capital)) {
			catalogue.set(capital, new Map().set(product, price));
		} else  {
			catalogue.set(capital, catalogue.get(capital).set(product, price));
		}
	});
	catalogue = new Map([...catalogue.entries()].sort());
	catalogue.forEach(function (list, letter) {
		console.log(`${letter}`);
		let keys = Object.keys(list);
		list = new Map([...list.entries()].sort());

		list.forEach(function (price, product) {
			console.log(`  ${product}: ${price}`);
		});
	});

}
