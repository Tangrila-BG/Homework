function modifyAverage([num]) {
	num = Number(num);
	let n = num;
	while (true) {
		n = Number(n);
		let temp = getAverageAndDigits(n);
		if (temp[0] / temp[1] <= 5)
			n += ""+9;
		else
			return n;
	}
	function getAverageAndDigits(n) {
		let digits = 0;
		let sum = 0;
		while (true) {
			digits++;
			sum += Math.floor(n % 10);
			if (n < 10)
				break;
			n /= 10;
		}
		return [sum, digits];
	}
}
