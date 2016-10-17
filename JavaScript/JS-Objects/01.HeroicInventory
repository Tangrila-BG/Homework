function heroicInventory(input) {
	let obj = [];
	input.forEach(function (x) {
		let temp = x.split(/\s+\/\s+/g);
		let [name, level, inventory] = [temp[0], temp[1], temp.slice(2).join('').split(/\,\s+/g)];
		level = Number(level);
		if (inventory.length == 1 && inventory[0] == '') inventory.pop();
		obj.push({
			name: name, level: level, items: inventory
		});
	});
	console.log(JSON.stringify(obj));
}
