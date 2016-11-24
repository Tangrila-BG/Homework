/**
 * Created by tangrila on 28-Oct-16.
 */

let sharedObject = {
	name: null,
	income: null,
	changeName: function (name) {
		if (name.length === 0) {
			return;
		}
		this.name = name;
		let newName = $('#name');
		newName.val(this.name);
	},
	changeIncome: function (income) {
		if (!Number.isInteger(income) || income <= 0) {
			return;
		}
		this.income = income;
		let newIncome = $('#income');
		newIncome.val(this.income);
	},
	updateName: function () {
		let newName = $('#name').val();
		if (newName.length === 0) {
			return;
		}
		this.name = newName;
	},
	updateIncome: function () {
		let newIncome = $('#income').val();
		if (isNaN(newIncome) || !Number.isInteger(Number(newIncome)) || Number(newIncome) <= 0) {
			return;
		}
		this.income = Number(newIncome);
	}
};

let expect = require("chai").expect;
let jsdom = require('jsdom-global')();
let $ = require('jquery');

document.body.innerHTML =
	`<div id="wrapper">
        <input type="text" id="name">
        <input type="text" id="income">
    </div>`;

describe("Test sharedObject", function () {
	let textBoxName;
	let textBoxIncome;
	beforeEach(function () {
		textBoxName = $('#name');
		textBoxIncome = $('#income');
		textBoxName.val('');
		textBoxIncome.val('');
		sharedObject.name = null;
		sharedObject.income = null;
	});

	it('should return null for sharedObject.name', function () {
		let actualValue = sharedObject.name;
		let expectedValue = null;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return null for sharedObject.income', function () {
		let actualValue = sharedObject.income;
		let expectedValue = null;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return "Tester" for sharedObject.name = "Tester"', function () {
		sharedObject.name = "Tester";
		let actualValue = sharedObject.name;
		let expectedValue = "Tester";
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return 100 for sharedObject.income = 100', function () {
		sharedObject.income = 100;
		let actualValue = sharedObject.income;
		let expectedValue = 100;
		expect(actualValue).to.be.equal(expectedValue);
	});

	describe("Test sharedObject.changeName('string')", function () {
		it('should return "Adam" for changeName("Adam")', function () {
			sharedObject.changeName("Adam");
			let actualValue = textBoxName.val();
			let expectedValue = "Adam";
			expect(actualValue).to.be.equal(expectedValue);
			expect(sharedObject.name).to.be.equal(expectedValue);
		});

		it('should return "Tester" for {changeName("Tester"); changeName("")}', function () {
			sharedObject.changeName("Tester"); sharedObject.changeName('');
			let actualValue = textBoxName.val();
			let expectedValue = "Tester";
			expect(actualValue).to.be.equal(expectedValue);
			expect(sharedObject.name).to.be.equal(expectedValue);
		});

		it('should return null for changeName("")', function () {
			sharedObject.changeName("");
			let actualValue = sharedObject.name;
			let expectedValue = null;
			expect(actualValue).to.be.equal(expectedValue);
			expect(textBoxName.val()).to.be.equal('');
		});
	});

	describe("Test sharedObject.changeIncome(number)", function () {
		it('should return "5" for changeIncome(5)', function () {
			sharedObject.changeIncome(5);
			let actualValue = textBoxIncome.val();
			let expectedValue = '5';
			expect(actualValue).to.be.equal(expectedValue);
			expect(sharedObject.income).to.be.equal(5);
		});

		it('should return "2" for {changeIncome(20); changeIncome(2)}', function () {
			sharedObject.changeIncome(20); sharedObject.changeIncome(2);
			let actualValue = textBoxIncome.val();
			let expectedValue = '2';
			expect(actualValue).to.be.equal(expectedValue);
			expect(sharedObject.income).to.be.equal(2);
		});

		it('should return "" for changeIncome("test")', function () {
			sharedObject.changeIncome("test");
			let actualValue = textBoxIncome.val();
			let expectedValue = "";
			expect(actualValue).to.be.equal(expectedValue);
			expect(sharedObject.income).to.be.equal(null);
		});

		it('should return "" for changeIncome(2.9913)', function () {
			sharedObject.changeIncome(2.9913);
			let actualValue = textBoxIncome.val();
			let expectedValue = "";
			expect(actualValue).to.be.equal(expectedValue);
			expect(sharedObject.income).to.be.equal(null);
		});

		it('should return "1" for {changeIncome(1); changeIncome(-100)}', function () {
			sharedObject.changeIncome(1); sharedObject.changeIncome(-100);
			let actualValue = textBoxIncome.val();
			let expectedValue = "1";
			expect(actualValue).to.be.equal(expectedValue);
			expect(sharedObject.income).to.be.equal(1);
		});

		it('should return "" for changeIncome(0)', function () {
			let actualValue = textBoxIncome.val();
			let expectedValue = "";
			expect(actualValue).to.be.equal(expectedValue);
			expect(sharedObject.income).to.be.equal(null);
		});
	});

	describe("Test sharedObject.updateName()", function () {
		it('should return "Tester" for {changeName("Tester"); ' +
			'textBoxName.val("") ; updateName()}', function () {
			sharedObject.changeName('Tester');
			textBoxName.val('');
			let actualValue = textBoxName.val();
			let expectedValue = "";
			expect(actualValue).to.be.equal(expectedValue);
			expect(sharedObject.name).to.be.equal("Tester");
		});

		it('should return "Adam" for {changeName("testing");' +
			' textBoxName.val("Adam"); updateName()}', function () {
			sharedObject.changeName("testing");
			textBoxName.val('Adam');
			sharedObject.updateName();
			let actualValue = textBoxName.val();
			let expectedValue = "Adam";
			expect(actualValue).to.be.equal(expectedValue);
			expect(sharedObject.name).to.be.equal("Adam");
		});
	});
	
	describe("Test sharedObject.updateIncome()", function () {
		it('should return 25 for {sharedObject.changeIncome(25); ' +
			'textBoxIncome.val("testing"); sharedObject.updateIncome()}', function () {
			sharedObject.changeIncome(25);
			textBoxIncome.val('testing');
			sharedObject.updateIncome();
			let actualValue = sharedObject.income;
			let expectedValue = 25;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return 50 for {sharedObject.changeIncome(50); textBoxIncome.val("3.14"); sharedObject.updateIncome()}', function () {
			sharedObject.changeIncome(50);
			textBoxIncome.val('3.14');
			sharedObject.updateIncome();
			let actualValue = sharedObject.income;
			let expectedValue = 50;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return 3 for {sharedObject.changeIncome(3); textBoxIncome.val("-20"); sharedObject.updateIncome()}', function () {
			sharedObject.changeIncome(3);
			textBoxIncome.val('-20');
			sharedObject.updateIncome();
			let actualValue = sharedObject.income;
			let expectedValue = 3;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return 100 for {sharedObject.changeIncome(100); textBoxIncome.val(""); sharedObject.updateIncome()}', function () {
			sharedObject.changeIncome(100);
			textBoxIncome.val('');
			sharedObject.updateIncome();
			let actualValue = sharedObject.income;
			let expectedValue = 100;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return 15 for {sharedObject.changeIncome(5); textBoxIncome.val("15"); sharedObject.updateIncome()}', function () {
			sharedObject.changeIncome(5);
			textBoxIncome.val('15');
			sharedObject.updateIncome();
			let actualValue = sharedObject.income;
			let expectedValue = 15;
			expect(actualValue).to.be.equal(expectedValue);
		});
	});
});


