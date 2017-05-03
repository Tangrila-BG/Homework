/**
 * Created by tangrila on 04-Nov-16.
 */
let Person = function() {
	class Person {

		constructor(name) {
			this.name = name;
		}

		toString() {
			return `I'm ${this.name}`;
		}
	}

	return {
		Person
	}
}();