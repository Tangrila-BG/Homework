function compoundInterest([pSum, interest, period, timespan]) {
	let freq = 12 / period;
	interest *= 0.01;

	let result = pSum * Math.pow(1 + interest / freq, freq * timespan);
	return result.toFixed(2);
};
