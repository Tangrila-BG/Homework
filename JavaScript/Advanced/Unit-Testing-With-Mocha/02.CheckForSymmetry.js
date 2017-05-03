/**
 * Created by tangrila on 28-Oct-16.
 */
function isSymmetric(arr) {
	if (!Array.isArray(arr))
		return false; // Non-arrays are non-symmetric
	let reversed = arr.slice(0).reverse(); // Clone and reverse
	let equal = (JSON.stringify(arr) == JSON.stringify(reversed));
	return equal;
}
let expect = require("chai").expect;
describe("Test isSymmetric(arr)", function () {
    it('should return true for ["12345"]', function () {
        let actualValue = isSymmetric(['12345']);
	    let expectedValue = true;
	    expect(actualValue).to.be.equal(expectedValue);
    });

	it('should return true for [-1, 2, -1]', function () {
		let actualValue = isSymmetric([-1, 2, -1]);
		let expectedValue = true;
		expect(actualValue).to.be.equal(expectedValue);
	});
	
	it('should return false for [1, 2]', function () {
		let actualValue = isSymmetric([1, 2]);
		let expectedValue = false;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return false for []', function () {
		let actualValue = isSymmetric([]);
		let expectedValue = true;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return true for [5, "hi", {a:5}, new Date(), {a:5}, "hi", 5]', function () {
		let actualValue = isSymmetric([5, "hi", {a: 5}, new Date(), {a: 5}, "hi", 5]);
		let expectedValue = true;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return true for [1]', function () {
		let actualValue = isSymmetric([1]);
		let expectedValue = true;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return false for "string"', function () {
		let actualValue = isSymmetric("string");
		let expectedValue = false;
		expect(actualValue).to.be.equal(expectedValue);
	});
});