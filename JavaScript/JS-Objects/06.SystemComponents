function systemComponents(input) {
	let systemComponents = new Map();
	input.forEach(function (x) {
		let [system, component, subComponent] = x.split(/\s+\|\s+/g);
		if (!systemComponents.has(system))
			systemComponents.set(system, new Map().set(component, new Array(subComponent)));
		else if (!systemComponents.get(system).has(component))
			systemComponents.set(system, systemComponents.get(system).set(component, new Array(subComponent)));
		else
			systemComponents.get(system).get(component).push(subComponent);

	});
	let firstBy=(function(){function e(f){f.thenBy=t;return f}function t(y,x){x=this;return e(function(a,b){return x(a,b)||y(a,b)})}return e})();
	systemComponents = new Map([...systemComponents.entries()].sort(firstBy(function (v1, v2) {
		return [...v2[1]].length - [...v1[1]].length;
	}).thenBy(function (v1, v2) {
		return v2[0] < v1[0];
	})));
	systemComponents.forEach( function (components, system) {
		console.log(system);
		components = new Map([...components.entries()].sort((a, b) => b[1].length-a[1].length));
		components.forEach(function (subComponents, component) {
			console.log('|||' + component);
			subComponents.forEach(x => console.log('||||||' + x));
		});
	});
}
