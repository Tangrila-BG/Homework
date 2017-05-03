function lowestPricesInCities(input) {
	let lowestPrices = new Map();
	input.forEach(function (x) {
		let [city, product, price] = x.split(/\s\|\s/g);
		price = Number(price);
		if (!lowestPrices.has(product)){
			lowestPrices.set(product, new Map());
		}
		lowestPrices.get(product).set(city, price);
	});
	lowestPrices.forEach(function (value, key) {
		let lowestPrice = Array.from(value.entries()).sort(function (first, second) {
			return first[1] - second[1];
		})[0];
		console.log(`${key} -> ${lowestPrice[1]} (${lowestPrice[0]})`)
	})
}
