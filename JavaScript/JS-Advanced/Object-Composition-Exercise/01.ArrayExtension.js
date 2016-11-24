/**
 * Created by tangrila on 26-Oct-16.
 */
(function idiot() {
	Array.prototype.last = function () {
		return this[this.length - 1];
	};
	Array.prototype.skip = function (n) {
		return this.slice(n);
	};
	Array.prototype.take = function (n) {
		return this.slice(0, n);
	};
	Array.prototype.sum = function () {
		return Array.from(this).reduce((a, b) => a + b);
	};
	Array.prototype.average = function () {
		return Array.from(this).reduce((a, b) => a + b) / this.length;
	};
})();
let pesho = [1, 5, 3, 5];
console.log(pesho.sum());
console.log(pesho.average());
console.log(pesho.take(2));
console.log(pesho.skip(2));
console.log(pesho.last());
console.log(pesho);
