/**
 * Created by tangrila on 29-Oct-16.
 */
class Request {
	constructor(method, uri, version, message) {
		this.method = method;
		this.uri = uri;
		this.version = version;
		this.message = message;
		this.response = undefined;
		this.fulfilled = false;
	}
}
let test = new Request('GET', 'http://google.com', 'HTTP/1.1', 'Hello');
/*
console.log(test.method);
console.log(test.uri);
console.log(test.version);
console.log(test.message);
console.log(test.response);
console.log(test.fulfilled);
*/
