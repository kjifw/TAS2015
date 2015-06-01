"use strict";

function findThirdDigit (numberAsStr) {
	var number = undefined,
	reminder = undefined,
	thirdDigit = 7,
	result = "";

	if (numberAsStr && (numberAsStr % 1 === 0)) {	
		number = numberAsStr | 0;		
	}

	if (number < 0) {
		reminder = Math.abs(number);
	} else {
		reminder = number;
	}
	
	reminder = Math.floor(reminder / 100);
	reminder = reminder % 10;

	if (reminder == 7) {
		result = "third digit is 7";
	} else {
		result = "third digit is not 7";
	}

	return result;
}