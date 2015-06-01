"use strict";

function calculateRectArea (widthAsStr, heightAsStr) {
	var width = undefined,
	height = undefined,
	rectArea = undefined,
	result = "";

	if ((widthAsStr && (widthAsStr % 1 === 0 || widthAsStr % 1 !== 0)) && 
		(heightAsStr && (heightAsStr % 1 === 0 || heightAsStr % 1 !== 0))) {
		width = Number(widthAsStr);
		height = Number(heightAsStr);
		rectArea = width * height;
		result = "area = " + rectArea;
	} else {
		result = "incorrect width or height";
	}

	return result;
}