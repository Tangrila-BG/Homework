function cookByNumbers(input) {
	let num = Number(bill[0]);
	for (let i = 1; i < bill.length; i++) {
		if (bill[i] == "chop")
			num /= 2;
		if (bill[i] == "dice")
			num = Math.sqrt(num);
		if (bill[i] == "spice")
			num++;
		if (bill[i] == "bake")
			num *= 3;
		if (bill[i] == "fillet")
			num -= (num * 0.20);
		console.log(num);
	}
}
