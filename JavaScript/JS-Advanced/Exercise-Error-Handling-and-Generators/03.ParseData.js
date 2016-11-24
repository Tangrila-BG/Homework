/**
 * Created by tangrila on 10-Nov-16.
 */
function makeCandy(candies) {
	class Candy {
		constructor(topping, filling, spice) {
			this._topping = topping;
			this._filling = filling;
			this._spice = spice;

			// validation
			this.validate(topping, "topping");
			this.validate(filling, "filling");
			this.validate(spice, "spice");
		}

		get topping() {
			return this._topping;
		}

		set topping(param) {
			this.validate(param, "topping");
			this._topping = param;
		}

		get filling() {
			return this._filling;
		}

		set filling(param) {
			this.validate(param, "filling");
			this._filling = param;
		}

		get spice() {
			return this._spice;
		}

		set spice(param) {
			this.validate(param, "spice");
			this._spice = param;
		}

		validate(param, paramName) {
			let regex;
			switch (paramName) {
				case "topping":
					if (param == "") {
						this._topping = null;
						break;
					}
					regex = new RegExp(/^(milk|white|dark) chocolate$/);
					if (!regex.test(param))
						throw new TypeError();
					break;
				case "filling":
					let allowed = [
						'hazelnut', 'caramel', 'strawberry',
						'blueberry', 'yogurt', 'fudge', null
					];

					if (param == "") {
						this._filling = null;
						break;
					}

					param = param.split(',');
					param.forEach(p => {
						if (!allowed.includes(p))
							throw new TypeError();
					});

					break;
				case "spice":
					if (param == 'poison' || param == 'asbestos')
						throw new TypeError();
					else if (param == "")
						this._spice = null;
					break;
			}
		}
	}

	let recipes = [];
	candies.forEach(candy => {
		let [topping, filling, spice] = candy.split(':');
		try {
			let goodCandy = new Candy(topping, filling, spice);
			recipes.push(goodCandy);
		}
		catch (exception) {
			// nothing
		}
	});
	return recipes;
}
makeCandy([
	'milk chocolate:hazelnut,caramel:pumpkin',
	'dark chocolate::chips',
	'white chocolate::poison',  // invalid
	'white chocolate:fudge:',
	'frosting:yogurt:frosting', // invalid
	'dark chocolate:blueberry:rock crystals'
]);
