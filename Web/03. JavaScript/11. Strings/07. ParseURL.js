// For task condition please refer to https://github.com/TelerikAcademy/JavaScript-Fundamentals/tree/master/11.%20Strings
"use strict";

var text = "http://telerikacademy.com/Courses/Courses/Details/239";

console.log(text);

function parseUrl(text) {
	var parsed = "",
		protocol = "",
		server = "",
		resource = "",
		textArr = text.split(":"); 

	protocol = "protocol: " + textArr[0];

	textArr[1] = textArr[1].replace(/(\/\/)/, "");

	textArr = textArr[1].split(/(\/)/);

	server = "server: " + textArr[0];

	resource = "resource: ";
	for (var i = 1; i < textArr.length; i+=1) {
		resource += textArr[i];
	}

	parsed = protocol + "; " + server + "; "+ resource;
	return parsed;
}

var result = parseUrl(text);

console.log(result);