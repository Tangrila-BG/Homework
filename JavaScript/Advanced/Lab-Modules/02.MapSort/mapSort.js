/**
 * Created by tangrila on 04-Nov-16.
 */
function MapSort(map, method) {
	if (method === undefined)
		return new Map([...map.entries()].sort());
	return new Map([...map.entries()].sort(method));
}

module.exports = MapSort;