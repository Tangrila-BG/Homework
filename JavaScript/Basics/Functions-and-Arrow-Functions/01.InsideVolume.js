function insideVol(input) {
	bill = bill.map(Number);
	for (let i = 0; i < bill.length; i += 3) {
	    let x = bill[i];
		let y = bill[i + 1];
		let z = bill[i + 2];

		if (inVolume(x, y ,z))
			console.log('inside');
		else
			console.log('outside');
	}

	function inVolume(x, y, z) {
		let x1 = 10, x2 = 50;
		let y1 = 20, y2 = 80;
		let z1 = 15, z2 = 50;
		if (x >= x1 && x <= x2) {
			if (y >= y1 && y <= y2) {
				if (z >= z1 && z <= z2) {
					return true;
				}
			}
		}
		return false;
	}
}
