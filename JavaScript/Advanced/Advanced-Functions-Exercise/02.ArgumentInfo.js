/**
 * Created by tangrila on 23-Oct-16.
 */
function argumentInfo() {
	let summary = {};
	for (var i = 0; i < arguments.length; i++) {
		var obj = arguments[i];
		var type = typeof obj;
		if (!summary[type])
			summary[type] = 1;
		else summary[type]++;
		console.log(type + ': ' + obj);
	}
	let sortedTypes = [];
	for (let currentType in summary)
		sortedTypes.push([currentType, summary[currentType]]);
	sortedTypes = sortedTypes.sort((a, b) => {
		return b[1] - a[1];
	});
	sortedTypes.map(x => x.join(' = ')).forEach(x => console.log(x));
}
argumentInfo('cat','dog', 42, function () { console.log('Hello world!'); });