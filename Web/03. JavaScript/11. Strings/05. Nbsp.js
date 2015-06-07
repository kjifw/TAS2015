// For task condition please refer to https://github.com/TelerikAcademy/JavaScript-Fundamentals/tree/master/11.%20Strings
"use strict";

var text = "We are living in an yellow submarine.\
We don't have anything else.";

console.log(text);

function replaceWhiteSpace(text) {
	var symbol = "&nbsp",
		replacedText = "";

	replacedText = text.replace(/[\s]+/gim, symbol);

	return replacedText;
}

var result = replaceWhiteSpace(text);

console.log(result);