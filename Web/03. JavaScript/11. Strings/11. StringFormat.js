// For task condition please refer to https://github.com/TelerikAcademy/JavaScript-Fundamentals/tree/master/11.%20Strings
"use strict";

var text = "{0}, {1}, {0} text {2}";

function stringFormat () {
	var current,
		index,
	 	placeholder = /\{([0-9]+)\}/,
		text = arguments[0];

	while(true) {
		current = placeholder.exec(text);

		if (current == null || current == undefined) {
			break;
		}

		index = parseInt(current[1]) + 1;
		text = text.replace(current[0], arguments[index]);
	}

	return text;
}

var result = stringFormat(text, 1, "Pesho", "Gosho");

console.log(result);