function treasureLocator(input) {
	// Island name: x1, y1, x2, y2(top left, bottom right(start, end))
	let treasures = {
		"Tuvalu": [ [1, 1], [3, 3] ],
		"Tokelau": [ [8, 0], [9, 1] ],
		"Samoa": [ [5, 3], [7, 6] ],
		"Tonga": [ [0, 6], [2, 8] ],
		"Cook": [ [4, 7], [9, 8] ]
	};
	let result = [];
	for (let i = 0; i < bill.length; i += 2) {
		let x = bill[i];
		let y = bill[i + 1];
	    result.push(fetchFoundTreasures(x, y));
	}
	for (let item in result)
		console.log(result[item]);
		
	function fetchFoundTreasures(x, y) {
		for (let key in treasures) {
			// top left corner(start) of treasure island
			let treasureX1 = treasures[key][0][0];
			let treasureY1 = treasures[key][0][1];
			// bottom right corner(end) of treasure island
			let treasureX2 = treasures[key][1][0];
			let treasureY2 = treasures[key][1][1];

			if (x >= treasureX1 && x <= treasureX2 &&
				y >= treasureY1 && y <= treasureY2)
				return key;
		}
		return "On the bottom of the ocean";
	}
}
