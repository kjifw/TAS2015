"use strict";

function isInsideFigures (coordXStr, coordYStr) {
	var coordX = undefined,
	coordY = undefined,
	radius = 3,
	circleX = 1,
	circleY = 1,
	rectTop = 1,
	rectLeft = -1,
	rectWidth = 6,
	rectHeight = 2,
	dist = undefined,
	rectRight = undefined,
	rectBottom = undefined,
	isOutsideRect = undefined,
	result = "";

	if (coordXStr && (coordXStr % 1 === 0) || (coordXStr % 1 !== 0) &&
		coordYStr && (coordYStr % 1 === 0) || (coordYStr % 1 !== 0)) {
		coordX = Number(coordXStr);
		coordY = Number(coordYStr);

		if (!isNaN(coordX) && !isNaN(coordY)) {
			dist = Math.pow(coordX - circleX, 2) + Math.pow(coordY - circleY, 2) - Math.pow(radius, 2);
			rectRight = Math.abs(rectLeft - rectWidth);
			rectBottom = rectTop - rectHeight;
			isOutsideRect = coordY > rectTop || coordY < rectBottom || coordX > rectRight || coordX < rectLeft;

			if (dist == 0 && isOutsideRect){
				result = "The point is on the circle and outside of the rectangle.";
			} else if (dist == 0 && !isOutisdeRect){
				result = "The point is on the circle and inside of the rectangle.";
			} else{
				if (dist > 0 && isOutsideRect){
					result = "The point is outside of the circle and outside of the rectangle.";
				} else if (dist > 0 && !isOutsideRect){
					result = "The point is outside of the circle and inside of the rectangle.";
				} else{
					if (isOutsideRect){
						result = "The point is inside of the circle and outside of the rectangle.";
					} else {
						result = "The point is inside of the circle and inside of the rectangle.";
					}
				}
			}
		} else {
			result = "incorrect input";
		}
	} else {
		result = "incorrect input";
	}

	return result;
}