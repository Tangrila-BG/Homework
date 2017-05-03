function countWordsWithMaps(text) {
	let words = new Map();
	let re = /[\w]+/g;
	let ma = re.exec(text);
	while (ma) {
		let temp = ma[0].toLowerCase();
		if (!words.has(temp))
			words.set(temp, 1);
		else
			words.set(temp, Number(words.get(temp) + 1));
		ma = re.exec(text);
	}
	let sorted = Array.from(words.keys()).sort();
	for (let k in sorted) {
		console.log(`'${sorted[k]}' -> ${words.get(sorted[k])} times`);
	}
}
