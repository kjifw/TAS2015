// For task condition please refer to https://github.com/TelerikAcademy/JavaScript-Fundamentals/tree/master/11.%20Strings
"use strict";

var text = "<html><head><title>Sample title</title></head>\
<body><div>text <div>More text</div>and more...</div>in body</body></html>";

console.log(text);

function extractText(text) {
	var regex = /(<(.*?)>)/g,
		extracted = "";

	extracted = text.replace(regex, " ");
	extracted = extracted.replace(/(\s+)/g, " ").trim();

	return extracted;
}

var result = extractText(text);

console.log(result);