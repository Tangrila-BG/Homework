/**
 * Created by tangrila on 10-Nov-16.
 */
class CheckingAccount {
	constructor(clientId, email, firstName, lastName) {
		this._clientId = clientId;
		this._email = email;
		this._firstName = firstName;
		this._lastName = lastName;
		this._products = [];
		this.validateParams(clientId, "Client ID");
		this.validateParams(email, "e-mail");
		this.validateParams(firstName, "First name");
		this.validateParams(lastName, "Last name");
	}
	get clientId() {
		return this._clientId;
	}

	set clientId(param) {
		this.validateParams(param, "Client ID");
		this._clientId = param;
	}

	get email() {
		return this._email;
	}

	set email(param) {
		this.validateParams(param, "e-mail");
		this._email = param;
	}

	get firstName() {
		return this._firstName;
	}

	set firstName(param) {
		this.validateParams(param, "First name");
		this._firstName = param;
	}

	get lastName() {
		return this._lastName;
	}

	set lastName(param) {
		this.validateParams(param, "Last name");
		this._lastName = param;
	}

	validateParams(param, paramName) {
		let regex;
		switch (paramName) {
			case "Client ID":
				regex = new RegExp(/^\d{6}$/);
				if (!regex.test(param))
					throw new TypeError(`${paramName} must be a 6-digit number`);
				break;
			case "e-mail":
				regex = new RegExp(/[\w]+@[\w.]+/);
				if (!regex.test(param))
					throw new TypeError(`Invalid ${paramName}`);
				break;
			case "First name":
			case "Last name":
				regex = new RegExp(/^[a-zA-Z]+$/);

				if (param.length < 3 || param.length > 20)
					throw new TypeError(`${paramName} must be between 3 and 20 characters long`);

				if (!regex.test(param))
					throw new TypeError(`${paramName} must contain only Latin characters`);

				break;

		}
	}
}
// let acc = new CheckingAccount('1314', 'ivan@some.com', 'Ivan', 'Petrov');
// let acc = new CheckingAccount('131455', 'ivan@', 'Ivan', 'Petrov');
// let acc = new CheckingAccount('131455', 'ivan@some.com', 'I', 'Petrov')
let acc = new CheckingAccount('1314', 'ivan@some.com', 'Ivan', 'Petrov');