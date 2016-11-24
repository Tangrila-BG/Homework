/**
 * Created by tangrila on 04-Nov-16.
 */
let turtles = function () {
	class Turtle {
		constructor(name, age, gender) {
			if (new.target === Turtle) {
				throw new Error('Abstract class');
			}
			this._name = name;
			this._age = Number(age);
			this._gender = gender;
		}

		get name() {
			return this._name;
		}

		get age() {
			return this._age;
		}

		get gender() {
			return this._gender;
		}

		grow(age) {
			this._age += age;
		}

		toString() {
			return `Turtle: ${this._name}\n` +
				`Aged - ${this._age}; Gender - ${this._gender}`;
		}
	}

	class WaterTurtle extends Turtle {
		constructor(name, age, gender, waterPool) {
			super(name, age, gender);
			this._waterPool = waterPool;
		}

		get currentWaterPool() {
			return this._waterPool;
		}

		travel(waterPool) {
			this._waterPool = waterPool;
			this._age += 5;
		}

		toString() {
			return super.toString() +
				`\nCurrently inhabiting ${this._waterPool}`;
		}
	}

	class GalapagosTurtle extends Turtle {
		constructor(name, age, gender) {
			super(name, age, gender);
			this._eatenThings = [];
		}

		get thingsEaten() {
			return this._eatenThings;
		}

		eat(food) {
			this._eatenThings.push(food);
		}

		grow(age) {
			super.grow(age);
			this._eatenThings = [];
		}

		toString() {
			return super.toString() +
				`\nThings, eaten this year: ${this._eatenThings.join(', ')}`;
		}
	}

	class EvkodianTurtle extends Turtle {
		constructor(name, age, gender, evkodiumValue) {

			super(name, age, gender);
			this._evkodiumValue = {
				value: evkodiumValue,
				density: this._gender == 'male' ? this._age * 3 : this._age * 2
			};
		}

		get evkodium() {
			return this._evkodiumValue;
		}

		toString() {
			return super.toString() +
				`\nEvkodium: ${this._evkodiumValue.value * this._evkodiumValue.density}`;
		}
	}

	class NinjaTurtle extends Turtle {
		constructor(name, age, gender, maskColor, weapon) {
			super(name, age, gender);
			this.maskColor = maskColor;
			this.weapon = weapon;
			this._level = 0;
		}

		grow(age) {
			super.grow(age);
			this._level++;
		}

		toString() {
			if (this._level < 25) {
				return super.toString() +
					`\n${this._name.substring(0, 3)} wears a ${this.maskColor} mask, ` +
					`and is an apprentice with the ${this.weapon}.`
			}

			if (this._level >= 100) {
				return super.toString() +
					`\n${this._name.substring(0, 3)} wears a ${this.maskColor} mask, ` +
					`and is BEYOND GODLIKE with the ${this.weapon}.`
			}
			// this._level >= 25 && this_level < 100
			return super.toString() +
				`\n${this._name.substring(0, 3)} wears a ${this.maskColor} mask, ` +
				`and is smokin strong with the ${this.weapon}.`
		}
	}

	return {
		Turtle,
		WaterTurtle,
		GalapagosTurtle,
		EvkodianTurtle,
		NinjaTurtle
	}
}();

/*
let testWaterTurtle = new WaterTurtle("Michelangelo", 18, "male", "Sewer");
let testGalapagosTurtle = new GalapagosTurtle("Raphael", 18, "male");
let testEvkodianTurtle = new EvkodianTurtle("Donatello", 18, "male", 100);
let testNinjaTurtle = new NinjaTurtle("Leonardo", 18, "male", "Blue", "Yamato");

console.log(testWaterTurtle.toString());
// Turtle: Michelangelo
// Aged - 18; Gender - male
// Currently inhabiting Sewer

console.log(testGalapagosTurtle.toString());
// Turtle: Raphael
// Aged - 18; Gender - male
// Things, eaten this year:

console.log(testEvkodianTurtle.toString());
// Turtle: Donatello
// Aged - 18; Gender - male
// Evkodium: 5400

console.log(testNinjaTurtle.toString());
// Turtle: Leonardo
// Aged - 18; Gender - male
// Leo wears a Blue mask, and is an apprentice with the Yamato.
*/

module.exports = turtles;
