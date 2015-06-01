"use strict";

function oddOrEven (numberAsStr) {
	var isOdd = false,
	result = "",
	number = undefined;

	if (numberAsStr && (numberAsStr % 1 === 0)) {	
		number = numberAsStr | 0;
		if ((number & 1) == 1) {
			isOdd = true;
		}
		result = "is odd --> " + isOdd;
	} else {
		result = "not an integer number";
	}

	return result;
}