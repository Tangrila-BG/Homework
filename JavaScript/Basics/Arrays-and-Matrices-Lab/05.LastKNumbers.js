function lastKNumbers([n, k]) {
	[n, k] = [n, k].map(Number);
	let nums = [1];
	for (let i = 0; i < n-1; i++) {
	    let lastKSum = nums.slice( Math.max(nums.length - k, 0));
		lastKSum = lastKSum.reduce((a, b) => a + b);
		nums.push(lastKSum);
	}
	console.log(nums.join(' '));
}
