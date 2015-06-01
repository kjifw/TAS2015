"use strict";

function calculateTrapezoidArea (firstSideAsStr, secondSideAsStr, heightAsStr) {
	var firstSide = undefined,
	secondSide = undefined,
	height = undefined,
	area = undefined,
	result = "";

	var checkFirstSide = firstSideAsStr && (firstSideAsStr % 1 === 0) || (firstSideAsStr % 1 !== 0),
	checkSecondSide = secondSideAsStr && (secondSideAsStr % 1 === 0) || (secondSideAsStr % 1 !== 0),
	checkHeight = heightAsStr && (heightAsStr % 1 === 0) || (heightAsStr % 1 !== 0);

	if (checkFirstSide && checkSecondSide && checkHeight) {
		firstSide = Number(firstSideAsStr);
		secondSide = Number(secondSideAsStr);
		height = Number(heightAsStr);

		if (firstSide > 0 && secondSide > 0 && height > 0) {
			area = ((firstSide + secondSide) / 2) * height;
			result = "area = " + area;			
		} else {
			result = "incorrect input";
		}
	} else {
		result = "incorrect input";
	}

	return result;
}