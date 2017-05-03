/**
 * Created by tangrila on 25-Oct-16.
 */
function personalBMI() {
	let obj = {
		name: arguments[0],
		personalInfo: {
			age: Math.round(arguments[1]),
			weight: Math.round(arguments[2]),
			height: Math.round(arguments[3])
		},
		status: 'normal'
	};
	obj.BMI = Math.round(obj.personalInfo.weight /
		((obj.personalInfo.height/100) * (obj.personalInfo.height/100)));
	if (obj.BMI < 18.5) obj.status = 'underweight';
	if (obj.BMI >= 25 && obj.BMI < 30) obj.status = 'overweight';
	if (obj.BMI >= 30) {
		obj.status = 'obese';
		obj.recommendation = 'admission required';
	}
	return obj;
	
}
console.log(personalBMI(
'Peter', 29, 75, 182
));
personalBMI([
'Honey Boo Boo', 9, 57, 137
]);