/**
 * Created by tangrila on 04-Nov-16.
 */
let solve = function () {
	class Checkbox {
		constructor(label, selector) {
			this._label = label;
			this._elements = $(selector);
			this._value;
			this._selector = selector;
			if ($(selector).is(":checked"))
				this._value = true;
			else
				this._value = false;
		}

		get label() {
			return this._label;
		}

		get elements() {
			return this._elements;
		}

		get value() {
			if ($(this._selector).is(":checked"))
				this._value = true;
			else
				this._value = false;
			return this._value;
		}

		set value(val) {
			if (typeof(val) !== "boolean")
				throw new Error();
			this._value = val;
		}
	}

	class Numberbox {
		constructor(label, selector, minValue, maxValue) {
			this._label = label;
			this._elements = $(selector);
			this._value = minValue;
			this._minValue = minValue;
			this._maxValue = maxValue;
			this._selector = selector;
		}

		get label() {
			return this._label;
		}

		get elements() {
			return this._elements;
		}

		get value() {
			let val = Number($(this._selector).val());
			if (isNaN(val) && !Number.isInteger(val) &&
				val < this._minValue || val > this._maxValue)
				throw new Error();
			this._value = val;
			return this._value;
		}

		set value(val) {
			if (isNaN(val) || !Number.isInteger(val) ||
				val < this._minValue || val > this._maxValue)
				throw new Error();
			this._value = val;
		}
	}

	return {
		Checkbox,
		Numberbox
	}
}();

module.exports = solve;

/*
let check = new Checkbox("Is Married:","#married");
let number = new Numberbox("Age:","#age",1,100);
let checkbox = $('#married');
let numberbox = $('#age');
checkbox.on('change',()=>console.log(check.value));
numberbox.on('change',()=>console.log(number.value));
*/
