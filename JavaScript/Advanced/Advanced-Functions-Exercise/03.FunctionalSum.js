/**
 * Created by tangrila on 23-Oct-16.
 */
function functionalSum(n) {
		let v = (x) => {
			console.log(v);
			return functionalSum(n + x)
		};
		v.valueOf = () => {
			return n
		};
		return v;
}
console.log(functionalSum(1)(2)(3));