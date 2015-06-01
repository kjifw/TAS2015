"use strict";

function isPrimeNumber (numberAsStr) {
	var number = undefined,
	numberSqrt = undefined,
	isPrime = true, 
	result = "";

	if (numberAsStr && (numberAsStr % 1 === 0)) {	
		number = numberAsStr | 0;

		if (number < 2) {
			isPrime = false;
		}

		numberSqrt = Math.floor(Math.sqrt(number));

		for (var i = 2; i <= numberSqrt; i+=1) {
			if (number % i == 0) {
				isPrime = false;
			}
		}		
		result += isPrime;
	} else {
		result = "incorrect input";
	}

	return result;
}