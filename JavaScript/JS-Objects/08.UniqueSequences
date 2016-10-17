function uniqueSequences(input) {
	let uniqueSeqs = [];
	input.forEach( (x) => {
		let temp = new Set();
		let arr = [];
		x = JSON.parse(x);
		x = x.map(Number);
		x = Array.from(x).sort((a, b) => {
			return b-a;
		});
		x.forEach( (n) => {
			arr.push(n);
			temp.add(n);
		});
		if (arr.length == [...temp].length)  {
			uniqueSeqs.push(x);
		}
	});
	var hash = {};
	var out = [];
	for (var i = 0, l = uniqueSeqs.length; i < l; i++) {
		var key = uniqueSeqs[i].join('|');
		if (!hash[key]) {
			out.push(uniqueSeqs[i]);
			hash[key] = 'found';
		}
	}
	Array.from(out).sort( (a,b) => {
		return a.length-b.length || a.length == b.length;
		} ).forEach( (x) => {
			console.log('[' + x.join(', ') + ']');
		});
}
