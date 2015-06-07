// For task condition please refer to https://github.com/TelerikAcademy/JavaScript-Fundamentals/tree/master/11.%20Strings
"use strict";

var text = '<p>Please visit <a href="http://academy.telerik.com">our site</a>\
to choose a training course. Also visit <a href="www.devbg.org">our forum</a> \
to discuss the courses.</p>';

console.log(text);

function replaceTags(text) {
	var anchorOpeningTag,
		regexAnchorStart = /<a href="(.*?)">/,
		regexAnchorEnd = /<\/a>/g,
		replaced = text;
	
	while(true){
		anchorOpeningTag = regexAnchorStart.exec(replaced);

		if (anchorOpeningTag == null || anchorOpeningTag == undefined) {
			break;
		}

		replaced = replaced.replace(regexAnchorStart, "[URL=" + anchorOpeningTag[1] + "]");
	}

	replaced = replaced.replace(regexAnchorEnd, "[/URL]");
	return replaced;
}

var result = replaceTags(text);

console.log(result);