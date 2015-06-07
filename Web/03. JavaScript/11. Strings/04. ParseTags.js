// For task condition please refer to https://github.com/TelerikAcademy/JavaScript-Fundamentals/tree/master/11.%20Strings
"use strict";

var text = "We are <mixcase>living</mixcase> in an <upcase>yellow submarine</upcase>.\
We <mixcase>don't</mixcase> have <lowcase>ANYTHING</lowcase> else.";

console.log(text);

function parseTags(text) {
	var parsedText = text;

	parsedText = parsedText.replace(/<upcase>(.*?)<\/upcase>/g, function(x) {
		return x.toUpperCase().replace(/(<([^>]+)>)/g, "");
	});

	parsedText = parsedText.replace(/<lowcase>(.*?)<\/lowcase>/g, function (x) {
		return x.toLowerCase().replace(/(<([^>]+)>)/g, "");
	});

	parsedText = parsedText.replace(/<mixcase>(.*?)<\/mixcase>/g, function(x) {
		x = x.replace(/(<([^>]+)>)/g, "");
		var y = x.split("");
		
		for (var i = 0; i < y.length; i+=1) {
			y[i] = (Math.floor((Math.random() * 10) + 1)) < 6 ? y[i].toLowerCase() : y[i].toUpperCase(); 
		}

		x = y.join("");
		return x;
	});

	return parsedText;
}

var result = parseTags(text);

console.log(result);