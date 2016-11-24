/**
 * Created by tangrila on 27-Oct-16.
 */
function constructionCrew(input) {
	if (!input['handsShaking'])
		return input;

	input['bloodAlcoholLevel'] += 0.1 * input['weight'] * input['experience'];
	input['handsShaking'] = false;
	return input;
}
let test = { weight: 80,
	experience: 1,
	bloodAlcoholLevel: 0,
	handsShaking: true };


console.log(pesho(test));
console.log(test);