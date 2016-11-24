/**
 * Created by tangrila on 23-Oct-16.
 */
function commandProcessor(input) {
	let commandProcessor = (function () {
		let text = '';
		return {
			append: (t) => text = text + t,
			removeStart: (count) => text = text.slice(count),
			removeEnd: (count) => text = text.slice(0, text.length - count),
			print: function() { console.log(text) }
		};
	})();
	input.forEach(x => {
		let [cmdName, arg] = x.split(' ');
		commandProcessor[cmdName](arg);
	});
}
commandProcessor([
	'append hello',
	'append again',
	'removeStart 3',
	'removeEnd 4',
	'print'
]);
commandProcessor([
	'append 123',
	'append 45',
	'removeStart 2',
	'removeEnd 1',
	'print'
]);