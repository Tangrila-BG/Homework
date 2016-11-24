/**
 * Created by tangrila on 07-Nov-16.
 */
let list = (function(){
	let data = [];
	return {
		add: function(item) {
			data.push(item);
		},
		delete: function(index) {
			if (Number.isInteger(index) && index >= 0 && index < data.length) {
				return data.splice(index, 1)[0];
			} else {
				return undefined;
			}
		},
		toString: function() {
			return data.join(", ");
		}
	};
})();

let expect = require("chai").expect;

describe(`Test list`, function () {
	let test;
	beforeEach(() => {
		test = list;
	});
    describe(`Test add`, function () {
	    it(`should return ["pesho", 2.1] for {add("pesho"); add(2.1)}`, function () {
			test.add("pesho"); test.add(2.1);
		    let actualValue = test.toString();
		    let expectedValue = `pesho, 2.1`;
		    expect(actualValue).to.equal(expectedValue);
	    });
    });
	
	describe(`Test delete`, function () {
		it(`should return pesho for {add(1.2); add("pesho"); delete(0)}`, function () {
			test.add(1.2); test.add("pesho"); test.delete(0);
			let actualValue = test.delete(0);
			let expectedValue = "pesho";
			expect(actualValue).to.equal(expectedValue);
		});

		it(`should return undefined for {add("pesho"); delete(1)}`, function () {
			test.add("pesho");
			let actualValue = undefined;
			let expectedValue = test.delete(1);
			expect(actualValue).to.equal(expectedValue);
		});
	});
});