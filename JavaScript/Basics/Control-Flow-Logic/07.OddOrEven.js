function oddOrEven([num]) {
	num = Math.abs(num);
	return num % 2 == 0
		? "even"
		: num % 2 == 1
		? "odd"
		: "invalid";
}
