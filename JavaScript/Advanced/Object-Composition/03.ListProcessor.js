/**
 * Created by tangrila on 23-Oct-16.
 */
function listProcessor(input) {
	let commandProcessor =  (function () {
		let list = [];
		return {
			add: (newItem) => list.push(newItem),
			remove: (item) => list = list.filter(x => x != item),
			print: () => console.log(list)
		}
	})();
	for (let cmd of input) {
		let [cmdName, arg] = cmd.split(' ');
		commandProcessor[cmdName](arg);
	}
}
listProcessor(['add hello', 'add again', 'remove hello', 'add again', 'print']);
listProcessor(['add hello', 'add again', 'remove hello', 'add again', 'print']);
listProcessor(['add pesho', 'add gosho', 'add pesho', 'remove pesho','print']);