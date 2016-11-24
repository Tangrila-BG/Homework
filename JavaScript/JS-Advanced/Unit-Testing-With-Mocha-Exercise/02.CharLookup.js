/**
 * Created by tangrila on 28-Oct-16.
 */
function lookupChar(string, index) {
	if (typeof(string) !== 'string' || !Number.isInteger(index)) {
		return undefined;
	}
	if (string.length <= index || index < 0) {
		return "Incorrect index";
	}

	return string.charAt(index);
}

let expect = require("chai").expect;

describe("Test lookupChar(string, index)", function () {
	it('should return undefined for (1, 1)', function () {
		let actualValue = lookupChar(1, 1);
		let expectedValue = undefined;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return undefined for ("test", "2")', function () {
		let actualValue = lookupChar("test", "2");
		let expectedValue = undefined;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return undefined for ("test", 2.3)', function () {
		let actualValue = lookupChar("test", 2.3);
		let expectedValue = undefined;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return "Incorrect index" for ("test", -1)', function () {
		let actualValue = lookupChar("test", -1);
		let expectedValue = "Incorrect index";
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return "Incorrect index" for ("test", 100)', function () {
		let actualValue = lookupChar("test", 100);
		let expectedValue = "Incorrect index";
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return "Incorrect index" for ("", 0)', function () {
		let actualValue = lookupChar("", 0);
		let expectedValue = "Incorrect index";
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return "t" for ("tesp", 0)', function () {
		let actualValue = lookupChar("tesp", 0);
		let expectedValue = "t";
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return "p" for ("tesp", 3)', function () {
		let actualValue = lookupChar("tesp", 3);
		let expectedValue = "p";
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return "m" for ("stamat", 3)', function () {
		let actualValue = lookupChar("stamat", 3);
		let expectedValue = "m";
		expect(actualValue).to.be.equal(expectedValue);
	});

});

console.log("".charAt(0));