function cityMarkets(input) {
	// map Cities { City, map Products { product, income} }
	let cities = new Map();
	input.forEach(function (x) {
		let [city, product, stock, price] = x.split(/\s->\s|\s:\s/g);
		[stock, price] = [stock, price].map(Number);
		if (!cities.has(city))
			cities.set(city, new Map().set(product, stock * price));
		else
			cities.set(city, cities.get(city).set(product, stock * price));
	});
	for (let [city, products] of cities) {
		console.log(`Town - ${city}`);
		for (let [product, income] of products) {
			console.log(`$$$${product} : ${income}`);
		}
	}
}
