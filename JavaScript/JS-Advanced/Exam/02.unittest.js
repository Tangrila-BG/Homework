/**
 * Created by User on 13.11.2016 ã..
 */
function createList() {
    let data = [];
    return {
        add: function (item) {
            data.push(item)
        },
        shiftLeft: function () {
            if (data.length > 1) {
                let first = data.shift();
                data.push(first);
            }
        },
        shiftRight: function () {
            if (data.length > 1) {
                let last = data.pop();
                data.unshift(last);
            }
        },
        swap: function (index1, index2) {
            if (!Number.isInteger(index1) || index1 < 0 || index1 >= data.length ||
                !Number.isInteger(index2) || index2 < 0 || index2 >= data.length ||
                index1 === index2) {
                return false;
            }
            let temp = data[index1];
            data[index1] = data[index2];
            data[index2] = temp;
            return true;
        },
        toString: function () {
            return data.join(", ");
        }
    };
}

let expect = require('chai').expect;
let test;

describe(`Test createList`, function () {
    beforeEach(function () {
       test = createList();
    });

    it(`should return "" for nothing`, function () {
        test.add(1); test.shiftLeft();
        let actualValue = test.toString();
        let expectedValue = "1";
        expect(actualValue).to.equal(expectedValue);
    });

    describe(`Test add()`, function () {
        it(`should return "pesho" for add("pesho")`, function () {
            test.add("pesho");
            let actualValue = test.toString();
            let expectedValue = "pesho";
            expect(actualValue).to.equal(expectedValue);
        });

        it(`should return "adam, pesho" for {add("adam"); add("pesho")}`, function () {
            test.add("adam"); test.add("pesho");
            let actualValue = test.toString();
            let expectedValue = "adam, pesho";
            expect(actualValue).to.equal(expectedValue);
        });

        it(`should return 2, [object Object] for {add(2); add({})}`, function () {
            test.add(2); test.add({});
            let actualValue = test.toString();
            let expectedValue = "2, [object Object]";
            expect(actualValue).to.equal(expectedValue);
        });
    });

    describe(`Test shiftLeft()`, function () {
        it(`should return "adam, eve, pesho" for {add("pesho"); add("adam"); add("eve"); shiftLeft()}`, function () {
            test.add("pesho"); test.add("adam"); test.add("eve"); test.shiftLeft();
            let actualValue = test.toString();
            let expectedValue = "adam, eve, pesho";
            expect(actualValue).to.equal(expectedValue);
        });
    });

    describe(`Test shiftRight()`, function () {
        it(`should return "eve, pesho, adam" for {add("pesho"); add("adam"); add("eve"); shiftRight()}`, function () {
            test.add("pesho"); test.add("adam"); test.add("eve"); test.shiftRight();
            let actualValue = test.toString();
            let expectedValue = "eve, pesho, adam";
            expect(actualValue).to.equal(expectedValue);
        });
    });

    describe(`Test swap()`, function () {
        it(`should return true for {add("pesho"); add("adam"); swap(0, 1)}`, function () {
            test.add("pesho"); test.add("adam");
            let actualValue = test.swap(0, 1);
            let expectedValue = true;
            expect(actualValue).to.equal(expectedValue);
        });

        it(`should return false for {add("pesho"); add("adam"); swap(-1, 1)}`, function () {
            test.add("pesho"); test.add("adam");
            let actualValue = test.swap(-1, 1);
            let expectedValue = false;
            expect(actualValue).to.equal(expectedValue);
        });

        it(`should return false for {add("pesho"); add("adam"); swap(0, 2)}`, function () {
            test.add("pesho"); test.add("adam");
            let actualValue = test.swap(0, 2);
            let expectedValue = false;
            expect(actualValue).to.equal(expectedValue);
        });

        it(`should return false for {add("pesho"); add("adam"); swap(0, 0)}`, function () {
            test.add("pesho"); test.add("adam");
            let actualValue = test.swap(0, 0);
            let expectedValue = false;
            expect(actualValue).to.equal(expectedValue);
        });

        it(`should return false for {add("pesho"); add("adam"); swap("pesho", 2)}`, function () {
            test.add("pesho"); test.add("adam");
            let actualValue = test.swap("pesho", 0);
            let expectedValue = false;
            expect(actualValue).to.equal(expectedValue);
        });

        it(`should return false for {swap(0, 0)}`, function () {
            let actualValue = test.swap(0, 0);
            let expectedValue = false;
            expect(actualValue).to.equal(expectedValue);
            expect(test.toString()).to.equal("");
        });
    });

    describe(`Test toString()`, function () {
        it(`should return "pesho, adam" for {add("pesho"); add("adam"); toString()}`, function () {
            test.add("pesho"); test.add("adam");
            let actualValue = test.toString();
            let expectedValue = "pesho, adam";
            expect(actualValue).to.equal(expectedValue);
        });

        it(`should return "" for toString()`, function () {
            let actualValue = test.toString();
            let expectedValue = "";
            expect(actualValue).to.equal(expectedValue);
        });
    });
});