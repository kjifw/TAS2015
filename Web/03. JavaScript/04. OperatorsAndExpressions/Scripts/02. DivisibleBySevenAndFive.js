"use strict";

function divisibleBySevenAndFive (numberAsStr) {
	var divisor = 35,
	divident = undefined,
	divisionResult = undefined, 
	result = "";

	if (numberAsStr && (numberAsStr % 1 === 0)) {
		divident = numberAsStr | 0;
		divisionResult = (divident % divisor) === 0 ? true : false;
		result = "Divisible by 7 and 5 --> " + divisionResult;
	} else {
		result = "not a number";
	}

	return result;
}