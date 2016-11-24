/**
 * Created by tangrila on 29-Oct-16.
 */
function nuke(selector1, selector2) {
	if (selector1 === selector2) return;
	$(selector1).filter(selector2).remove();
}

let chai = require("chai");
let expect = chai.expect;
let jsdom = require('jsdom-global')();
let $ = require('jquery');

document.body.innerHTML =
	`<div id="target">
    	<div class="nested target">
        	<p>This is some text</p>
    	</div>
    	<div class="target">
        	<p>Empty div</p>
    	</div>
    	<div class="inside">
        	<span class="nested">Some more text</span>
        	<span class="target">Some more text</span>
    	</div>
	</div>`;


describe("Test nuke(jquerySelector1, jquerySelector2)", function () {
	it('should do nothing for nuke("#target", "#target")', function () {
		let expectedValue = $('#target').clone();
		nuke('#target', '#target');
		let actualValue = $('#target');
		//$('#target').append($('<div>Axel</div>'));
		console.log($(actualValue).children());
		console.log($(expectedValue).children());
		let check = expectedValue.is(actualValue);
		chai.assert.strictEqual(expectedValue, actualValue);
	});
});