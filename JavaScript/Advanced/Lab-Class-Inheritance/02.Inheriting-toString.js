/**
 * Created by tangrila on 02-Nov-16.
 */
//function inheritingToString() {
	class Person {
		constructor(name, email) {
			this.name = name;
			this.email = email;
		}

		toString() {
			let className = this.constructor.name;
			let result = `${className} (`;

			let obj = this;
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

/*	return {
		Person,
		Student,
		Teacher
	}
}*/



let person = new Person('pesho', 'pesho@abv.bg');
console.log(person.toString());
let teacher = new Teacher('petar', 'petar@abv.bg', 'Math');
console.log(teacher.toString());
let student = new Student('Adam', 'adam@abv.bg', 'Math');
console.log(student.toString());