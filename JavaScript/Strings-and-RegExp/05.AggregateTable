function aggregateTable(input) {
	let temp = bill.map(x => x.split('|').filter(e => e != '').map(s => s.trim()));
	let cities = [];
	let sum = Number(0);
	for (let row in temp) {
		for (let element in temp[row]) {
			if (element == 0) cities.push(temp[row][element]);
			else sum += Number(temp[row][element]);
		}
	}
	console.log(cities.join(', '));
	console.log(sum);
}
