/**
 * Created by tangrila on 28-Oct-16.
 */
function sum(arr) {
	let sum = 0;
	for (num of arr)
		sum += Number(num);
	return sum;
}

let expect = require("chai").expect;

describe("Test sum(arr)", function () {
	it('should return 3 for [1, 2]', function () {
		let expectedSum = 3;
		let actualSum = sum([1, 2]);
		expect(actualSum).to.be.equal(expectedSum)
	});

	it('should return 2 for [2]', function () {
	    let expectedSum = 2;
		let actualSum = sum([2]);
		expect(actualSum).to.be.equal(expectedSum);
	});

	it('should return 0 for [0]', function () {
	    let expectedValue = 0;
		let actualValue = sum([0]);
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return NaN for []', function () {
	    let actualValue = sum([]);
		expect(actualValue).to.be.equal.NaN;
	});

	it('should return NaN for ["string"]', function () {
		let actualValue = sum(['pesho']);
		expect(actualValue).to.be.equal.NaN;
	});
});

