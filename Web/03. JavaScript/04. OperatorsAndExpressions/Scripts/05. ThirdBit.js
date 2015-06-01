"use strict";

function findThirdBit (numberAsStr) {
	var number = undefined,
	bitMask = 8,
	result = "";

	if (numberAsStr && (numberAsStr % 1 === 0)) {	
		number = numberAsStr | 0;		
	}

	if (number >= 0) {
		result = "number in binary: " + number.toString(2);
		result += "<br />" + "third bit is: ";

		if ((number & 8) == 0) {
			result += "0";
		} else {
			result += "1";
		}
	} else {
		result = "incorrect number";
	}
	
	return result;
}