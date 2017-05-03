/**
 * Created by tangrila on 25-Oct-16.
 */
let temp = (() => {
	let ingredients = {
		protein: 0,
		carbohydrate: 0,
		fat: 0,
		flavour: 0
	};
	let menu = {
		apple: {carbohydrate: 1, flavour: 2},
		coke: {carbohydrate: 10, flavour: 20},
		burger: {carbohydrate: 5, fat: 7, flavour: 3},
		omelet: {protein: 5, fat: 1, flavour: 1},
		cheverme: {protein: 10, carbohydrate: 10, fat: 10, flavour: 10}
	};
	function restock([ingredient, quantity]) {
		ingredients[ingredient] += Number(quantity);
		return 'Success';
	}
	function prepare([recipe, quantity]) {
		quantity = Number(quantity);
		let recipeIngredients = Object.create(menu[recipe]);

		// up the needed ingredients according to the specified quantity
		for (let ingredient in recipeIngredients)
			recipeIngredients[ingredient] *= quantity;

		// check if all the needed ingredients are available else error
		for (let ingredient in recipeIngredients) {
			if (ingredients[ingredient] - recipeIngredients[ingredient] < 0)
				return `Error: not enough ${ingredient} in stock`;
		}

		// perform the recipe, reduce the stock according to the recipe needs
		for (let ingredient in recipeIngredients) {
			ingredients[ingredient] -= recipeIngredients[ingredient];
		}

		return 'Success';
	}
	function report () {
		let report = '';
		for (let ingredient in ingredients)
			report += `${ingredient}=${ingredients[ingredient]} `;
		return report.trim();
	}

	return (input) => {
		let tokens = input.split(/ /);
		let commandName = tokens.shift();
		let args = tokens;
		switch (commandName) {
			case 'prepare':
				return prepare(args);
				break;
			case 'restock':
				return restock(args);
				break;
			default:
				return report();
				break;
		}
	}
})();
// test 0.1
/*console.log(
	temp.restock('flavour', 50),
	temp.prepare('coke', 4)
);*/

// test 0.2
console.log(temp('restock carbohydrate 10'));
console.log(temp('restock flavour 10'));
console.log(temp('prepare apple 1'));
console.log(temp('restock fat 10'));
console.log(temp('prepare burger 1'));
console.log(temp('report'));

// test 0.3
/*console.log(temp('prepare cheverme 1'));
console.log(temp('restock protein 10'));
console.log(temp('prepare cheverme 1'));
console.log(temp('restock carbohydrate 10'));
console.log(temp('prepare cheverme 1'));
console.log(temp('restock fat 10'));
console.log(temp('prepare cheverme 1'));
console.log(temp('restock flavour 10'));
console.log(temp('prepare cheverme 1'));
console.log(temp('report'));*/
