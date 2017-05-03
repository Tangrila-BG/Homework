/**
 * Created by tangrila on 30-Oct-16.
 */
class Rat {

	constructor(name) {
		this.name = name;
		this.unitedRats = [];
	}

	unite(otherRat) {
		if (otherRat.constructor.name == 'Rat')
			this.unitedRats.push(otherRat);
	}

	getRats() {
		return this.unitedRats;
	}

	toString() {
		let result = this.name;
		this.unitedRats.forEach(rat => {
			result += `\n##${rat.name}`;
		});
		return result;
	}
}

let rat1 = new Rat('pesho');
let rat2 = new Rat('gosho');
console.log(rat1);
rat1.unite(rat2);
console.log(rat1.getRats());

