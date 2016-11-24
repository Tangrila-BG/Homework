/**
 * Created by tangrila on 09-Nov-16.
 */
function printDeckOfCards(cards) {
	class Card {
		constructor(face, suit) {
			this.faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
			this.suits = new Map()
				.set('S', '\u2660')
				.set('H', '\u2665')
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
	let deck = [];
	for (let i = 0; i < cards.length; i++) {
		let faceAndSuit = cards[i];
		let card;
		let face = faceAndSuit.length == 3
			? faceAndSuit.substring(0, 2)
			: faceAndSuit.substring(0, 1);
		let suit = faceAndSuit[faceAndSuit.length - 1];

		try {
			card = new Card(face, suit);
			deck.push(card);
		} catch (exception) {
			console.log(`Invalid card: ${face + suit}`);
			return;
		}
	}
	console.log(deck.join(' '));
}

printDeckOfCards(['AS', '10D', 'KH', '2C']);
printDeckOfCards(['5S', '3D', 'QD', '1C']);