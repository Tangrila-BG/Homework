/**
 * Created by tangrila on 23-Oct-16.
 */
function cars(input) {
	let cars = new Map();

	for (let line of input) {
		let tokens = line.split(' ');
		switch (tokens[0]) {
			case 'create':
				if (tokens.length == 2)
					create(tokens[1]);
				else
					inherit(tokens[1], tokens[3]);
				break;
			case 'set':
				set(tokens[1], tokens[2], tokens[3]);
				break;
			case 'print':
				print(tokens[1]);
				break;
		}
 	}

	function create(name) {
		let car = {};
		cars.set(name, car);
	}
	
	function inherit(name, parent) {
		parent = cars.get(parent);
		let car = Object.create(parent);
		cars.set(name, car);
	}

	function set(name, key, value) {
		let car = cars.get(name);
		car[key] = value;
	}
	function print(name) {
		let car = cars.get(name);
		let props = [];
		for (let prop in car)
			props.push(`${prop}:${car[prop]}`);
		console.log(props.join(', '));
	}
}
cars([
	'create c1',
	'create c2 inherit c1',
	'set c1 color red',
	'set c2 model new',
	'print c1',
	'print c2'
	]
);
