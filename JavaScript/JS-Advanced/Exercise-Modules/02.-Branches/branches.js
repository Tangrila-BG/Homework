/**
 * Created by tangrila on 04-Nov-16.
 */
let firms = function () {
	class Branch {
		constructor(id, branchName, companyName) {
			this._id = id;
			this._branchName = branchName;
			this._companyName = companyName;
			this._employees = [];
		}

		get employees() {
			return this._employees;
		}

		hire(employee) {
			if (!(employee instanceof Employee))
				throw new TypeError();

			this._employees.push(employee);
		}

		toString() {
			if (this._employees.length == 0)
				return `@ ${this._companyName}, ${this._branchName}, ${this._id}\n` +
					`Employed:\nNone...`;

			return `@ ${this._companyName}, ${this._branchName}, ${this._id}\n` +
				`Employed:\n` + `${this._employees.map(e => `** ${e.toString()}`).join('\n')}`;
		}
	}

	class Employee {
		constructor(name, age, position) {
			this.name = name;
			this.age = age;
			this.position = position;
		}

		toString() {
			return `${this.name}, ${this.age} (${this.position})`;
		}
	}

	return {
		Branch,
		Employee
	}
}();

/*let employee1 = new Employee("Peter Ivanov", 25, "Regular Worker");
let employee2 = new Employee("Ivan Peterov", 24, "Regular Worker");
let employee3 = new Employee("John Hissie", 21, "CEO");

console.log(employee3.toString());
// John Hissie, 21 (CEO)

let branch1 = new Branch(1, "Four Streets Branch", "Default INC.");
branch1.hire(employee1);
branch1.hire(employee2);
branch1.hire(employee3);
console.log(branch1.toString());
// Employed:
// ** Peter Ivanov, 25 (Regular Worker)
// ** Ivan Peterov, 24 (Regular Worker)
// ** John Hissie, 21 (CEO)*/

module.exports = firms;