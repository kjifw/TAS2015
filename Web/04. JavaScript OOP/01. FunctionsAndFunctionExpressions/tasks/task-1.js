/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(args) {
	"use strict";
	
	var arrSum = 0;

	if (args.length === 0) {
		return null;
	}

	for (var i = 0; i < args.length; i+=1) {
		if (isNaN(args[i])) {
			throw new Error();
		}

		arrSum += +args[i];	
	}

	return arrSum;
}

module.exports = sum;