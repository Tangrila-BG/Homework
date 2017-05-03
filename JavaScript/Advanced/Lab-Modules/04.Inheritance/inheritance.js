/**
 * Created by tangrila on 04-Nov-16.
 */
let solve = function solve() {
	class Entity {
		constructor(name) {
			if (new.target === Entity){
				throw new Error();
			}
			this.name = name;
		}
	}

	class Dog extends Entity {
		constructor(name) {
			super(name);
		}

		saySomething() {
			return `${this.name} barks!`;
		}
	}

	class Person extends Entity {
		constructor(name, phrase, dog) {
			if (!(dog instanceof Dog))
				return new TypeError();

			super(name);
			this.phrase = phrase;
			this.dog = dog;
		}

		saySomething() {
			return `${this.name} says: ${this.phrase}${this.dog.name} barks!`;
		}
	}

	class Student extends Person {
		constructor(name, phrase, dog, id) {
			if (!(dog instanceof Dog))
				return new TypeError();
			if (isNaN(id))
				return new TypeError();

			super(name, phrase, dog);
			this.id = Number(id);
		}

		saySomething() {
			return `Id: ${this.id} ${this.name} says: ${this.phrase}${this.dog.name} barks!`;
		}
	}

	return {
		Entity,
		Dog,
		Person,
		Student
	}
}();

module.exports = solve;
