/**
 * Created by tangrila on 10-Nov-16.
 */
function validateRequest(object) {
	let regex = new RegExp(/^(GET|POST|DELETE|CONNECT)$/);
	if (!regex.test(object.method))
		throw new Error("Invalid request header: Invalid Method");

	regex = new RegExp(/^[\w\d\.\-]+\w$|\*$/);
	if (!regex.test(object.uri))
		throw new Error("Invalid request header: Invalid URI");

	regex = new RegExp(/^(HTTP\/0\.9|HTTP\/1\.0|HTTP\/1\.1|HTTP\/2\.0)$/g);
	if (!regex.test(object.version))
		throw new Error("Invalid request header: Invalid Version");

	// TODO: Message validation!
}