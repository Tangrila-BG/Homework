function populationInTowns(input) {
	let towns = new Map();
	input.forEach(function (x) {
		let [town, pop] = x.split(/\s<->\s/g);
		pop = Number(pop);
		if (!towns.has(town))
			towns.set(town, pop);
		else
			towns.set(town, towns.get(town) + pop);
	});
	for (let [k, v] of towns)
		console.log(`${k} : ${v}`);
}
