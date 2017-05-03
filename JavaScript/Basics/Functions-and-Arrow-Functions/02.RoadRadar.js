function radar([speed, zone]) {
	function getLimit(zone) {
		switch(zone) {
			case 'motorway': return 130;
			case 'interstate': return 90;
			case 'city': return 50;
			case 'residential': return 20;
		}
	}

	function getInFraction(speed, limit) {
		let overSpeed = speed - limit;
		if (overSpeed <= 0) {
			return false;
		}
		else if (overSpeed <= 20)
			return "speeding";
		else if (overSpeed <= 40)
			return "excessive speeding";
		return "reckless driving";
	}

	let limit = getLimit(zone);
	let infraction = getInFraction(speed, limit);
	if (infraction)
		console.log(infraction);

}
