/**
 * Created by tangrila on 01-Nov-16.
 */
let test = (function () {
	let ID = 0;

	return class Record {
		constructor(temperature, humidity, pressure, windSpeed) {
			this.id = ID;
			this.temperature = temperature;
			this.humidity = humidity;
			this.pressure = pressure;
			this.windSpeed = windSpeed;
			ID++;
		}

		status() {
			if (this.temperature < 20 &&
				(this.pressure < 700 || this.pressure > 900) &&
				this.windSpeed > 25) {
				return 'Stormy';
			}
			return 'Not stormy';
		}

		toString() {
			return `Reading ID: ${this.id}\n` +
				`Temperature: ${this.temperature}*C\n` +
				`Relative Humidity: ${this.humidity}%\n` +
				`Pressure: ${this.pressure}hpa\n` +
				`Wind Speed: ${this.windSpeed}m/s\n` +
				`Weather: ${this.status()}`;
		}
	}
}());

let record1 = new test(32, 66, 760, 12);
console.log(record1.toString());
console.log();
let record2 = new test(10, 40, 680, 30);
console.log(record2.toString());
