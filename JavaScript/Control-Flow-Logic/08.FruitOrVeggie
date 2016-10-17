function fruitOrVeggie([product]) {
	let products = {
		fruit: [
			"banana", "apple", "kiwi", "cherry",
			"lemon", "grapes", "peach"
		],
		vegetable: [
			"tomato", "cucumber", "pepper",
			"onion", "garlic", "parsley"
		]
	};
	let productCategory = Object.getOwnPropertyNames(products);
	let result;
	if (products.fruit.indexOf(product) != -1)
		result = productCategory[0];
	else if (products.vegetable.indexOf(product) != -1)
		result = productCategory[1];
	else
		result = "unknown";
	return result;
}
