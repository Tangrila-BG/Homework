function employeeData(data) {
	let pattern = /^([A-Z][a-zA-Z]*) \- ([1-9][0-9]*) \- ([a-zA-Z0-9 -]+)$/;
	for (let employee of data) {
		let match = pattern.exec(employee);
		if (match) {
			console.log(`Name: ${match[1]}`);
			console.log(`Position: ${match[3]}`);
			console.log(`Salary: ${match[2]}`);
		}
	}
}
