function usernames(input) {
	let usernames = new Set();

	input.forEach( (x) => {
		//console.log(x);
		usernames.add(x);
	});
	let firstBy=(function(){function e(f){f.thenBy=t;return f}function t(y,x){x=this;return e(function(a,b){return x(a,b)||y(a,b)})}return e})();
	let result = [...usernames].sort(firstBy((a, b) => {
		return a.length - b.length;
	}).thenBy( (a, b) => {
		return a.localeCompare(b);
	}));

	console.log(
		result.join('\n')
	);
}
