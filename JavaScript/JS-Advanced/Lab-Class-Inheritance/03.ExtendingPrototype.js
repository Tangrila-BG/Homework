/**
 * Created by tangrila on 02-Nov-16.
 */
class Person {
	constructor(name, email) {
		this.name = name;
		this.email = email;
	}

	toString() {
		let className = this.constructor.name;
		let result = `${className} (`;

		let obj = JSON.parse(JSON.stringify(this));
		let temp = [];
		for (let prop in obj) {
			temp.push(`${prop}: ${obj[prop]}`);
		}
		result += temp.join(', ');
		result += ')';

		return result;
	}
}
class Student extends Person {
	constructor(name, email, course) {
		super(name, email);
		this.course = course;
	}
}
class Teacher extends Person {
	constructor(name, email, subject) {
		super(name, email);
		this.subject = subject;
	}
}

function extendClass(classToExtend) {
	//TODO
	classToExtend.prototype.species = 'Human';
	classToExtend.prototype.toSpeciesString = function () {
		return `I am a ${this.species}. ${this.toString()}`;
	}

}
extendClass(Person);
let tester = new Person('adam', 'adamov@abv.bg');
console.log(tester.toSpeciesString());