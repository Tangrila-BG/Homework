function isPrime([num]) {
	num = Number(num);

	if (num === 2)
		return "true";
	if (num % 2 == 0 || num < 2)
		return "false";
	let boundary = Math.floor(Math.sqrt(num));
	for (var i = 2; i <= boundary; i++) {
		if (num % i == 0)
			return "false";
	}
	return "true";
}
