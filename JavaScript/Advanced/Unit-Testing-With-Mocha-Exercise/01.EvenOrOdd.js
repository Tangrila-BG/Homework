/**
 * Created by tangrila on 28-Oct-16.
 */
function isOddOrEven(string) {
	if (typeof(string) !== 'string') {
		return undefined;
	}
	if (string.length % 2 === 0) {
		return "even";
	}
	return "odd";
}

let expect = require("chai").expect;

describe("Test isOddOrEven('string')", function () {
	it('should return undefined for []', function () {
		let actualValue = isOddOrEven([]);
		let expectedValue = undefined;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return "odd" for "abc"', function () {
		let actualValue = isOddOrEven("abc");
		let expectedValue = "odd";
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return "even" for "ab"', function () {
		let actualValue = isOddOrEven("ab");
		let expectedValue = "even";
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return "even" for ""', function () {
		let actualValue = isOddOrEven("");
		let expectedValue = "even";
		expect(actualValue).to.be.equal(expectedValue);
	});
});
