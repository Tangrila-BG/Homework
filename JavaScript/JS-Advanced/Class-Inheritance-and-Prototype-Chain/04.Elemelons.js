/**
 * Created by tangrila on 03-Nov-16.
 */
// function melons() {
	class Melon {
		constructor(weight, melonSort) {
			if (new.target === Melon)
				throw new Error("Abstract class cannot be instantiated directly");
			this.weight = Number(weight);
			this.melonSort = melonSort;
			this._elementIndex = weight * this.melonSort.length;
		}

		get elementIndex() {
			return this._elementIndex;
		}

		toString() {
			return `Element: ${this.constructor.name.replace("melon", "")}\n` +
				`Sort: ${this.melonSort}\n` +
				`Element Index: ${this.elementIndex}`;
		}
	}

	class Watermelon extends Melon {
		constructor(weight, melonSort) {
			super(weight, melonSort);

		}
	}

	class Firemelon extends Melon {
		constructor(weight, melonSort) {
			super(weight, melonSort);
		}
	}

	class Earthmelon extends Melon {
		constructor(weight, melonSort) {
			super(weight, melonSort);
		}
	}

	class Airmelon extends Melon {
		constructor(weight, melonSort) {
			super(weight, melonSort);
		}
	}

	class Melolemonmelon extends Melon {
		constructor(weight, melonSort) {
			super(weight, melonSort);
			this.melonElement = "Water";
			this.melonElements = [
				"Fire", "Earth", "Air"
			];
			this.invokedOnce = false;
		}

		morph() {
			if (!this.invokedOnce)
				this.melonElements.push(this.melonElement);
			let currentElement = this.melonElements.shift();
			this.melonElements.push(currentElement);
			this.melonElement = currentElement;
			this.invokedOnce = true;
			return this;
		}

		toString() {
			return `Element: ${this.melonElement}\n` +
				`Sort: ${this.melonSort}\n` +
				`Element Index: ${this.elementIndex}`;
		}
	}

/*	return {
		Melon,
		Watermelon,
		Firemelon,
		Earthmelon,
		Airmelon,
		Melolemonmelon
	}
}*/

/*
let test = new Airmelon(12.5, "Kingsize");
console.log(test.toString());
*/

/*
let testMorph = new Melolemonmelon(12.5, "Kingsize");
console.log(testMorph.toString());
testMorph.morph();
console.log(testMorph.toString());
testMorph.morph();
console.log(testMorph.toString());
testMorph.morph();
console.log(testMorph.toString());
testMorph.morph();
console.log(testMorph.toString());
testMorph.morph();
console.log(testMorph.toString());
testMorph.morph();
console.log(testMorph.toString());
testMorph.morph();
console.log(testMorph.toString());
testMorph.morph();
console.log(testMorph.toString());
console.log(testMorph.melonElements);
*/

// let testMelon = new Melon(); // throws TypeError: Cannot read property 'length' of undefined  WHOA WTF?!