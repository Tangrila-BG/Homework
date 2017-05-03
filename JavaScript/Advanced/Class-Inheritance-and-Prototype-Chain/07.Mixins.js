/**
 * Created by tangrila on 03-Nov-16.
 */

class Computer {
	constructor(manufacturer, processorSpeed, ram, hardDiskSpace) {
		if (new.target === Computer)
			throw new Error("Abstract class cannot be instantiated directly");
		this.manufacturer = manufacturer;
		this.processorSpeed = Number(processorSpeed);
		this.ram = Number(ram);
		this.hardDiskSpace = Number(hardDiskSpace);
	}
}

class Laptop extends Computer {
	constructor(manufacturer, processorSpeed, ram, hardDiskSpace, weight, color, battery) {
		if (!(battery instanceof Battery))
			throw new TypeError("Provided object is not of class Battery");

		super(manufacturer, processorSpeed, ram, hardDiskSpace);
		this.weight = Number(weight);
		this.color = color;
		this._battery = battery;
	}

	get battery() {
		return this._battery;
	}

	set battery(batteryInstance) {
		if (!(batteryInstance instanceof Battery))
			throw new TypeError("Provided object is not of class Battery");
		this._battery = batteryInstance;
	}
}

class Desktop extends Computer {
	constructor(manufacturer, processorSpeed, ram, hardDiskSpace, keyboard, monitor) {
		if (!(keyboard instanceof Keyboard))
			throw new TypeError("Provided object is not of class Keyboard");
		if (!(monitor instanceof Monitor))
			throw new TypeError("Provided object is not of class Monitor");

		super(manufacturer, processorSpeed, ram, hardDiskSpace);
		this._keyboard = keyboard;
		this._monitor = monitor;
	}

	get keyboard() {
		return this._keyboard;
	}

	set keyboard(keyboardInstance) {
		if (!(keyboardInstance instanceof Keyboard))
			throw new TypeError("Provided object is not of class Keyboard");
		this._keyboard = keyboardInstance;
	}

	get monitor() {
		return this._monitor;
	}

	set monitor(monitorInstance) {
		if (!(monitorInstance instanceof Monitor))
			throw new TypeError("Provided object is not of class Monitor");
		this._monitor = monitorInstance;
	}
}

class Peripheral {
	constructor(manufacturer) {
		if (new.target === Peripheral)
			throw new Error("Abstract class cannot be instantiated directly");
		this.manufacturer = manufacturer;
	}
}

class Keyboard extends Peripheral {
	constructor(manufacturer, responseTime) {
		super(manufacturer);
		this.responseTime = Number(responseTime);
	}
}

class Monitor extends Peripheral {
	constructor(manufacturer, width, height) {
		super(manufacturer);
		this.width = Number(width);
		this.height = Number(height);
	}
}

class Battery extends Peripheral {
	constructor(manufacturer, expectedLife) {
		super(manufacturer);
		this.expectedLife = Number(expectedLife);
	}
}


function mixin() {
	function computerQualityMixin(classToExtend) {
		classToExtend.prototype.getQuality = function () {
			return (this.processorSpeed +
				this.ram + this.hardDiskSpace) / 3;
		};

		classToExtend.prototype.isFast = function () {
			return this.processorSpeed > (this.ram / 4)
		};

		classToExtend.prototype.isRoomy = function () {
			return this.hardDiskSpace > Math.floor(this.ram * this.processorSpeed);
		}
	}

	function styleMixin(classToExtend) {
		classToExtend.prototype.isFullSet = function () {
			return this.manufacturer.localeCompare(this.keyboard.manufacturer) == 0 &&
				this.manufacturer.localeCompare(this.monitor.manufacturer) == 0
		};

		classToExtend.prototype.isClassy = function () {
			return this.battery > 3 &&
				(this.color.localeCompare("Silver") == 0 ||
				this.color.localeCompare("Black") == 0) &&
				this.weight < 3;
		}
	}

	return {
		computerQualityMixin,
		styleMixin
	}
}

let keyboard = new Keyboard('Benq',70);
let monitor = new Monitor('Benq',28,18);
let desktop = new Desktop("JAR Computers",3.3,8,1, keyboard, monitor);
styleMixin(Desktop);
console.log(desktop.isFullSet());
console.log(desktop.isClassy());
