/**
 * Created by tangrila on 01-Nov-16.
 */
class SortedList {
	constructor() {
		this.list = [];
	}

	add(element) {
		this.list.push(element);
		this.sort();
	}

	remove(index) {
		this.vrfyRange(index);
		this.list.splice(index, 1);
	}

	get(index) {
		this.vrfyRange(index);
		return this.list[index];
	}

	vrfyRange(index) {
		if (this.list.length == 0) throw new Error("Collection is empty.");
		if (index < 0 || index >= this.list.length) throw new Error("Index was outside the bounds of the collection.");
	}

	sort() {
		this.list.sort((a, b) => a - b);
	}

	get size() {
		return this.list.length;
	}
}

let expect = require("chai").expect;

describe("Test (class)SortedList", function () {
	let test;
	beforeEach(() => {
		test = new SortedList;
	}) ;

	describe("Test if all methods exist", function () {
		it('should return true("function") for typeOf SortedList == "function"', function () {
			let actualValue = typeof SortedList;
			let expectedValue = 'function';
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return true("function") for typeof SortedList.add', function () {
			let actualValue = typeof test.add;
			let expectedValue = 'function';
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return true("function") for typeof SortedList.remove', function () {
			let actualValue = typeof test.remove;
			let expectedValue = 'function';
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return true("function") for typeof SortedList.sort', function () {
			let actualValue = typeof test.sort;
			let expectedValue = 'function';
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return true("function") for typeof SortedList.vrfyRange', function () {
			let actualValue = typeof test.vrfyRange;
			let expectedValue = 'function';
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return true("function") for typeof SortedList.get', function () {
			let actualValue = typeof test.get;
			let expectedValue = 'function';
			expect(actualValue).to.be.equal(expectedValue);
		});
	});

	describe("Test if all properties exist", function () {
		it('should return true for SortedList.prototype.hasOwnProperty("size")', function () {
			let actualValue = SortedList.prototype.hasOwnProperty('size');
			let expectedValue = true;
			expect(actualValue).to.be.equal(expectedValue);
		});

		it('should return [] for test.list', function () {
			let actualValue = test.list;
			let expectedValue = [];
			expect(actualValue).to.deep.equal(expectedValue);
		});
	});

	describe("Test methods functionality", function () {
		describe(`Test sort // this is called every time add is!`, function () {
			it(`should return [-5, 1.2, 1.5, 10, 100,] for {add(100); add(-5); add(10); add(1.5); add(1.2)}`, function () {
				test.add(100); test.add(-5); test.add(10); test.add(1.5); test.add(1.2);
				let actualValue = test.list;
				let expectedValue = [-5, 1.2, 1.5, 10, 100,];
				expect(actualValue).to.deep.equal(expectedValue);
			});
		});

		describe(`Test vrfyRange // this is called every time get or remove is!`, function () {
			it(`should return "Index was outside the bounds of the collection." for {add(1); remove(2)}`, function () {
				test.add(1);
				expect(() => test.remove(2)).to.throw("Index was outside the bounds of the collection.");
			});

			it(`should return "Collection is empty." for {remove(0)}`, function () {
				expect(() => test.remove(2)).to.throw("Collection is empty.");
			});

			it(`should return "Index was outside the bounds of the collection." for {add(1); remove(-1)}`, function () {
				test.add(1);
				expect(() => test.remove(-1)).to.throw("Index was outside the bounds of the collection.");
			});

			it(`should return "Index was outside the bounds of the collection." for {add(1); get(1)}`, function () {
				test.add(1);
				expect(() => test.get(1)).to.throw("Index was outside the bounds of the collection.");
			});

			it(`should return "Collection is empty." for {get(0)}`, function () {
				expect(() => test.get(0)).to.throw("Collection is empty.");
			});

			it(`should return "Index was outside the bounds of the collection." for {add(1); get(-1)}`, function () {
				test.add(1);
				expect(() => test.get(-1)).to.throw("Index was outside the bounds of the collection.");
			});
		});

	    describe("Test add // sort is called every time add is!", function () {
		    it('should return [2, 5] for {add(2); add(5)}', function () {
			    test.add(2); test.add(5);
			    let actualValue = Array.from(test.list);
			    let expectedValue = [2, 5];
			    expect(actualValue).to.deep.equal(expectedValue);
		    });

		    it(`should return ['pesho', -1, 3.141592653589793, '5'] for {test.add('pesho'); test.add(Math.PI); test.add(-1); test.add('5')}`, function () {
			    test.add('pesho'); test.add(Math.PI); test.add(-1); test.add('5');
			    let actualValue = test.list;
			    let expectedValue = ['pesho', -1, 3.141592653589793, '5'];
			    expect(actualValue).to.deep.equal(expectedValue);
		    });
	    });

		describe(`Test remove // vrfyRange is called every time remove is!`, function () {
			it(`should return [] for {add(2); remove(0)}`, function () {
				test.add(2); test.remove(0);
				let actualValue = test.list;
				let expectedValue = [];
				expect(actualValue).to.deep.equal(expectedValue);
			});

			it(`should return [2] for {add(2); add(5); remove(1)}`, function () {
				test.add(2); test.add(5); test.remove(1);
				let actualValue = test.list;
				let expectedValue = [2];
				expect(actualValue).to.deep.equal(expectedValue);
			});

			it(`should return [5] for {add(2); add(5); remove(0)}`, function () {
				test.add(2); test.add(5); test.remove(0);
				let actualValue = test.list;
				let expectedValue = [5];
				expect(actualValue).to.deep.equal(expectedValue);
			});
		});
		
		describe(`Test get // vrfyRange is called every time get is!`, function () {
			it(`should return 2 for {add(2); get(0)}`, function () {
				test.add(2);
				let actualValue = test.get(0);
				let expectedValue = 2;
				expect(actualValue).to.equal(expectedValue);
			});
		});

		describe(`Test size`, function () {
			it(`should return 0 for size`, function () {
				let actualValue = test.size;
				let expectedValue = 0;
				expect(actualValue).to.equal(expectedValue);
			});

			it(`should return 3 for {add(2); add(1); add(3)}`, function () {
				test.add(2); test.add(1); test.add(3);
				let actualValue = 3;
				let expectedValue = test.size;
				expect(actualValue).to.equal(expectedValue);
			});

			it(`should return 2 for {add(2); add(1); add(3); remove(2)}`, function () {
				test.add(2); test.add(1); test.add(3); test.remove(2);
				let actualValue = 2;
				let expectedValue = test.size;
				expect(actualValue).to.equal(expectedValue);
			});
		});
	});
});