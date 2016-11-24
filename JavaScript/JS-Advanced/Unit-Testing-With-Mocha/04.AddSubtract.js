/**
 * Created by tangrila on 28-Oct-16.
 */
function createCalculator() {
	let value = 0;
	return {
		add: function(num) { value += Number(num); },
		subtract: function(num) { value -= Number(num); },
		get: function() { return value; }
	}
}

let expect = require("chai").expect;

describe("Test createCalculator()", function () {
    let calc;
	beforeEach(function () {
		calc = createCalculator();
	});

	it('should return 5 for {add 3; add 2}', function () {
		calc.add(3); calc.add(2);
		let actualValue = calc.get();
		let expectedValue = 5;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return -2 for {add 2; subtract 4}', function () {
		calc.add(2); calc.subtract(4);
		let actualValue = calc.get();
		let expectedValue = -2;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return 0 for {add 0}', function () {
		calc.add(0);
		let actualValue = calc.get();
		let expectedValue = 0;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return NaN for {add "string"}', function () {
		calc.add("string");
		let actualValue = calc.get();
		expect(actualValue).to.be.equal.NaN;
	});

	it('should return NaN for {subtract "string"}', function () {
		calc.subtract("string");
		let actualValue = calc.get();
		expect(actualValue).to.be.equal.NaN;
	});

	it('should return NaN for {add new Date()}', function () {
		calc.add(new Date());
		let actualValue = calc.get();
		expect(actualValue).to.be.equal.NaN;
	});

	it('should return NaN for {subtract {5:5}}', function () {
		calc.subtract(new Date());
		let actualValue = calc.get();
		expect(actualValue).to.be.equal.NaN;
	});

	it('should return 3.2 for {add 2.1; add 1.1}', function () {
		calc.add(2.1); calc.add(1.1);
		let actualValue = calc.get();
		let expectedValue = 2.1 + 1.1;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return -1 for {subtract 2.1; add 1.1}', function () {
		calc.subtract(2.1); calc.add(1.1);
		let actualValue = calc.get();
		let expectedValue = -2.1 + 1.1;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return 0 for {}', function () {
		let actualValue = calc.get();
		let expectedValue = 0;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return -2.501 for {add -3.8; add 0.2; subtract -1}', function () {
		calc.add(-3.8); calc.add(0.2); calc.subtract(-1);
		let actualValue = calc.get();
		let expectedValue = -3.8 + 0.2 - -1;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return 8 for {add "6"; add 2}', function () {
		calc.add('6'); calc.add(2);
		let actualValue = calc.get();
		let expectedValue = 8;
		expect(actualValue).to.be.equal(expectedValue);
	});
});