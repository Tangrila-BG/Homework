/**
 * Created by tangrila on 09-Nov-16.
 */
class TimeSpan {
	constructor(hours, minutes, seconds) {
		this.checkParam(hours, 'hours');
		this.checkParam(minutes, 'minutes');
		this.checkParam(seconds, 'seconds');

		this.hours = hours;
		this.minutes = minutes;
		this.seconds = seconds;
		this.fix(seconds, 'seconds');
		this.fix(minutes, 'minutes');
		this.fix(hours, 'hours');
	}

	checkParam(param, type) {
		if (isNaN(param))
			throw new RangeError(`Invalid ${type}: ${param}`);
	}

	fix(param, type) {
		// positive
		if (type == 'seconds' && param > 59) {
			this.minutes += Math.floor(this.seconds / 60);
			this.seconds %= 60;
		}

		if (type == 'minutes' && param > 59) {
			this.hours += Math.floor(this.minutes / 60);
			this.hours %= 60;
		}

		if (type == 'hours' && param > 24)
			this.hours %= 24;

		// negative
		if (type == 'seconds' && param < 0) {
			this.minutes -= this.seconds % 60;
			this.seconds += 60;
			this.se
		}
	}

	toString() {
		return `${this.hours}:${this.minutes}:${this.seconds}`;
	}

}

// console.log('' + new TimeSpan('', 2.5, {}));
console.log('' + new TimeSpan(7, 8, 5));
console.log('' + new TimeSpan(12, 76, -5));