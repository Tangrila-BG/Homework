function matchMultiplication([bill]) {
	let re = /(-?\d+)\s*\*\s*(-?\d+\.?\d*)/g;
	bill = bill.replace(re, (match, num1, num2) => Number(num1)*Number(num2));
	console.log(bill)
}
