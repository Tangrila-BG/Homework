/**
 * Created by tangrila on 26-Oct-16.
 */
function gcd(a, b) {
	if (b == 0)
		return a;
	else
		return gcd(b, a % b)
}
console.log(gcd(252, 105));