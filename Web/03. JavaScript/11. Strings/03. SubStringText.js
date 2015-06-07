// For task condition please refer to https://github.com/TelerikAcademy/JavaScript-Fundamentals/tree/master/11.%20Strings
"use strict";

var hitsCount,
 	text = "We are living in an yellow submarine.\
			We don't have anything else. Inside the submarine is very tight.\
			So we are drinking all the day. We will move out of it in 5 days.",
	subString = "in";

function countSubStrInText (text, subStr) {
	var count = 0,
		textArr = text.split(/[\s,.?!]+/);

	for (var i = 0; i < textArr.length; i+=1) {
		count += (textArr[i].match(new RegExp(subStr, "gi")) || "").length;
	}

	return count;
}

hitsCount = countSubStrInText(text, subString);

console.log(hitsCount);