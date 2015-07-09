/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(start, end) {
	"use strict";

	var numberSqrt,
		isPrime,
		arr = [];

	if (isNaN(start) || isNaN(end)) {
		throw new Error();
	}

	start = +start;
	end = +end;

	for (var num = start; num <= end; num+=1) {
		isPrime = true;	

		if (num < 2) {
			isPrime = false;
			continue;
		}

		numberSqrt = Math.sqrt(num);

		for (var i = 2; i <= numberSqrt; i+=1) {
			if (num % i === 0) {
				isPrime = false;
				break;
			}	
		}

		if (isPrime) {
			arr.push(num);
		}
	}

	return arr;
}

module.exports = findPrimes;
