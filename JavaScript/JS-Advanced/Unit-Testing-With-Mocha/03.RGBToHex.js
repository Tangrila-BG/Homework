/**
 * Created by tangrila on 28-Oct-16.
 */
function rgbToHexColor(red, green, blue) {
	if (!Number.isInteger(red) || (red < 0) || (red > 255))
		return undefined; // Red value is invalid
	if (!Number.isInteger(green) || (green < 0) || (green > 255))
		return undefined; // Green value is invalid
	if (!Number.isInteger(blue) || (blue < 0) || (blue > 255))
		return undefined; // Blue value is invalid
	return "#" +
		("0" + red.toString(16).toUpperCase()).slice(-2) +
		("0" + green.toString(16).toUpperCase()).slice(-2) +
		("0" + blue.toString(16).toUpperCase()).slice(-2);
}

let expect = require("chai").expect;

describe("Test rgbToHexColor(red, green, blue)", function () {
    it('should return #FF9EAA for (255, 158, 170)', function () {
        let actualValue = rgbToHexColor(255, 158, 170);
	    let expectedValue = "#FF9EAA"
	    expect(actualValue).to.be.equal(expectedValue);
    });

	it('should return undefined for (-1, 2, 5)', function () {
		let actualValue = rgbToHexColor(-1, 2, 5);
		let expectedValue = undefined;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return undefined for (1, -1, 5)', function () {
		let actualValue = rgbToHexColor(1, -1, 5);
		let expectedValue = undefined;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return undefined for (1, 1, -1)', function () {
		let actualValue = rgbToHexColor(1, 1, -1);
		let expectedValue = undefined;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return undefined for (260, 260, 260)', function () {
		let actualValue = rgbToHexColor(260, 260, 260);
		let expectedValue = undefined;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return undefined for ("pesho", {a:5}, new Date())', function () {
		let actualValue = rgbToHexColor("pesho", {a:5}, new Date());
		let expectedValue = undefined;
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return #0C0D0E for (12, 13, 14)', function () {
		let actualValue = rgbToHexColor(12, 13, 14);
		let expectedValue = "#0C0D0E";
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return #000000 for (0, 0, 0)', function () {
		let actualValue = rgbToHexColor(0, 0, 0);
		let expectedValue = "#000000";
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return #FFFFFF for (255, 255, 255)', function () {
		let actualValue = rgbToHexColor(255, 255, 255);
		let expectedValue = "#FFFFFF";
		expect(actualValue).to.be.equal(expectedValue);
	});

	it('should return undefined for (3.14, 0, 255)', function () {
		let actualValue = rgbToHexColor(3.14, 0, 255);
		let expectedValue = undefined;
		expect(actualValue).to.be.equal(expectedValue);
	});
});