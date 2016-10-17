function autoEngineeringCompany(input) {
	// map Company { string Make, map Models { string Model, number Produced} } 
	let company = new Map();
	input.forEach(function (x) {
		let [make, model, produced] = x.split(/\s+\|\s+/g);
		produced = Number(produced);
		if (!company.has(make)) {
			company.set(make, new Map().set(model, produced));
		} else if (!company.get(make).has(model)) {
			company.set(make, company.get(make).set(model, produced));
		} else {
			company.set(make, company.get(make).set(model, company.get(make).get(model) + produced))
		}
	});
	company.forEach(function (models, make) {
		console.log(make);
		models.forEach( function (produced, model) {
			console.log(`###${model} -> ${produced}`);
		});
	});
}
