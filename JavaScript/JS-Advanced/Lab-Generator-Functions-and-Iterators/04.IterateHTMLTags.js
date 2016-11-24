/**
 * Created by tangrila on 10-Nov-16.
 */
let html = `
	<html>
	<body>
		<p align='center'><span lang='en'>Hello</span>, HTML
		</p> Bye, bye
	</body>
	</html>`;
for (let tag of extractTags(html)) {
	console.log(tag);
}
function* extractTags(html) {
	let regex = new RegExp(/<.*?>/g);
	let match;
	while (match = regex.exec(html)) {
		let tag = match[0];
		yield tag;
	}
}