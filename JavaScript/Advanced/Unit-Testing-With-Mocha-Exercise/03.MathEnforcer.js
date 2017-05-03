/**
 * Created by tangrila on 28-Oct-16.
 */
let mathEnforcer = {
	addFive: function (num) {
		if (typeof(num) !== 'number') {
			return undefined;
		}
		return num + 5;
	},
	subtractTen: function (num) {
		if (typeof(num) !== 'number') {
			return undefined;
		}
		return num - 10;
	},
	sum: function (num1, num2) {
		if (typeof(num1) !== 'number' || typeof(num2) !== 'number') {
			return undefined;
		}
		return num1 + num2;
	}
};

let expect = require("chai").expect;

describe("Test mathEnforcer", function () {
	describe("Test mathEnforcer.addFive(num)", function () {
		it('should return 5 for addFive(0)', function () {
			let actualValue = mathEnforcer.addFive(0);
			let expectedValue = 5;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return 0 for addFive(-5)', function () {
			let actualValue = mathEnforcer.addFive(-5);
			let expectedValue = 0;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return undefined for addFive("5")', function () {
			let actualValue = mathEnforcer.addFive('5');
			let expectedValue = undefined;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return 6.23221 for addFive(1.23221)', function () {
			let actualValue = mathEnforcer.addFive(1.23221);
			let expectedValue = 5 + 1.23221;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return -3.7677899999999998 for addFive(1.23221)', function () {
			let actualValue = mathEnforcer.addFive(-1.23221);
			let expectedValue = 5 + -1.23221;
			expect(actualValue).to.be.equal(expectedValue);
		});
	});	
	
	describe("Test mathEnforcer.subtractTen(num)", function () {
		it('should return -10 for subtractTen(0)', function () {
			let actualValue = mathEnforcer.subtractTen(0);
			let expectedValue = -10;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return -20 for subtractTen(-10)', function () {
			let actualValue = mathEnforcer.subtractTen(-10);
			let expectedValue = -20;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return undefined for subtractTen("10")', function () {
			let actualValue = mathEnforcer.subtractTen("10");
			let expectedValue = undefined;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return -14.499933221 for subtractTen(-4.499933221)', function () {
			let actualValue = mathEnforcer.subtractTen(-4.499933221);
			let expectedValue = -14.499933221;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return -5.500066779 for subtractTen(4.499933221)', function () {
			let actualValue = mathEnforcer.subtractTen(4.49993322);
			let expectedValue = 4.49993322 - 10;
			expect(actualValue).to.be.equal(expectedValue);
		});
	});
	
	describe("Test mathEnforcer.sum(num1, num2)", function () {
		it('should return 2 for sum(1, 1)', function () {
			let actualValue = mathEnforcer.sum(1, 1);
			let expectedValue = 2;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return -2 for sum(-1, -1)', function () {
			let actualValue = mathEnforcer.sum(-1, -1);
			let expectedValue = -2;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return undefined for sum("5", 5)', function () {
			let actualValue = mathEnforcer.sum("5", 5);
			let expectedValue = undefined;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return undefined for sum(5, "5")', function () {
			let actualValue = mathEnforcer.sum(5, "5");
			let expectedValue = undefined;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return -2.2110000000000003 for sum(-5.323, 3.112)', function () {
			let actualValue = mathEnforcer.sum(-5.323, 3.112);
			let expectedValue = -2.2110000000000003;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return 6.436902 for sum(5.32391, 1.112992)', function () {
			let actualValue = mathEnforcer.sum(5.32391, 1.112992);
			let expectedValue = 6.436902;
			expect(actualValue).to.be.equal(expectedValue);
		});
	});
});