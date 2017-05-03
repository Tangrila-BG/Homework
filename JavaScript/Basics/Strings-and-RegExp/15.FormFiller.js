function formFiller(input) {
	let username = bill[0];
	let email = bill[1];
	let phone = bill[2];
	let result = [];
	for (let i = 0; i < bill.length; i++) {
		bill[i] = bill[i].replace(/<![a-zA-Z]+!>/g, username)
			.replace(/<\@[a-zA-Z]+\@>/g, email)
			.replace(/<\+[a-zA-Z]+\+>/g, phone);
	}
	console.log(bill.slice(3).join('\n'));
}
