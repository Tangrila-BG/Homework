/**
 * Created by tangrila on 20-Sep-16.
 */
function calcNextDay([year, month, day]) {
	let date = new Date(year, month-1, day);
	let nextDate = new Date(date);
	nextDate.setDate(date.getDate() + 1);

	return nextDate.getFullYear() + "-" +
		(nextDate.getMonth() + 1) + "-" +
			nextDate.getDate();
};

console.log(calcNextDay(['2016', '9', '30']))
