/**
 * Created by tangrila on 23-Oct-16.
 */
function sortArray (arr, command) {
	let sorting = {
		asc: (arr) => arr.map(Number).sort((a,b) => a-b),
		desc: (arr) => arr.map(Number).sort((a,b) => b-a)
	};
	return sorting[command](arr);
}