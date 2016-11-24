/**
 * Created by tangrila on 08-Nov-16.
 */
class Card {
	constructor(face, suit) {
		this.faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
		this.suits = new Map()
			.set('S', '\u2660')
			.set('H','\u2665')
			.set('D', '\u2666')
			.set('C', '\u2663');

		if (!this.faces.includes(face) || ![...this.suits.keys()].includes(suit))
			throw new Error('problem');
		this._face = face;
		this._suit = [...this.suits.entries()].filter(x => x[0] == suit)[0][1];

	}
	get suit() {
		return this._suit;
	}
	get face() {
		return this._face;
	}
	set suit(val) {
		if (!this.faces.includes(val))
			throw new Error('problem');
		this._suit = val;
	}

	set face(val) {
		if (![...this.suits.keys()].includes(val))
			throw new Error('problem');
		this._face = [...this.suits.entries()].filter(x => x[0] == val)[0][1];
	}

	toString() {
		return this.face + this.suit;
	}
}
console.log('' + new Card('A', 'S'));
console.log('' + new Card('10', 'H'));
console.log('' + new Card('J', 'D'));
let card = new Card('J', 'D');
