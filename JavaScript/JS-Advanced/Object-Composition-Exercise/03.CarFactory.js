/**
 * Created by tangrila on 27-Oct-16.
 */
function carFactory(input) {
	let engines = {
		small: { power: 90, volume: 1800 },
		normal: { power: 120, volume: 2400 },
		monster: { power: 200, volume: 3500 }
	};
	let carriages = {
		hatchback: { type: 'hatchback', color: '' },
		coupe: { type: 'coupe', color: '' }
	};
	let car = {};
	// returns correct size wheels : odd number
	if (input['wheelsize'] % 2 != 1)
		input['wheelsize'] -= 1;

	for (let prop in input) {
		if (prop == 'color') continue;
		else if (prop == 'power') {
			pickEngine(input[prop], prop);
		} else if (prop == 'carriage') {
			carriages[input[prop]].color = input['color'];
			car[prop] = carriages[input[prop]];
		} else if (prop == 'wheelsize')
			car['wheels'] = (input[prop]+' ').repeat(4).trim().split(' ').map(Number);
		else
			car[prop] = input[prop];
	}

	function pickEngine(power, prop) {
		let alreadySpecified = Object.keys(engines)
			.filter(key => engines[key].power == power);
		if (alreadySpecified == 0) {
			let max = 0;
			for (let type in engines) {
				if (engines[type].power - power > max)
					max = engines[type];
			}
			car['engine'] = max;
		} else car['engine'] = engines[alreadySpecified];
	}
	return car;
}
let test ={
	model: 'Opel Vectra',
	power: 110,
	color: 'grey',
	carriage: 'coupe',
	wheelsize: 17
};


console.log(pesho(test));
