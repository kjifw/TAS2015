// For task condition please refer to https://github.com/TelerikAcademy/JavaScript-Fundamentals/tree/master/11.%20Strings
"use strict";

var checkResult,
	expression = "((a+b)/5-d)";

function isExpressionCorrect (expr) {
	var count = 0,
		result = true;

	for (var i = 0; i < expr.length; i+=1) {
		if (expr[i] == "(") {
			count++;
		}

		if (expr[i] == ")") {
			count--;
		}
	}

	if (count != 0) {
		result = false;
	}

	return result;
}


checkResult = isExpressionCorrect(expression);

console.log(checkResult);