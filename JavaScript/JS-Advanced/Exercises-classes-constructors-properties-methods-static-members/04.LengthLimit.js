/**
 * Created by tangrila on 30-Oct-16.
 */
class Stringer {
	constructor(string) {
		this.innerString = string;
		this.innerLength = this.innerString.length;
	}
	
	increase(length) {
		if (!Number(length) || length < 0) return;
		this.innerLength += length;
	}
	
	decrease(length) {
		if (!Number(length)) return;
		this.innerLength -= length;
		if (this.innerLength < 3) this.innerLength = 0;
	}

	toString() {
		if (this.innerLength == 0)
			return '...';
		if (this.innerString.length > this.innerLength) {
			return this.innerString.substring(0, this.innerLength) + '...';
		}

		return this.innerString;
	}
}

let str = new Stringer('pesho');

console.log(str.innerString);
console.log(str.innerLength);
str.decrease(2);
console.log(str.innerLength);
console.log(str.toString());