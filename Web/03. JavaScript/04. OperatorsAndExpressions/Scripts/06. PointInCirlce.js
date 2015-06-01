"use strict";

function pointIsInsideCircle (coordXStr, coordYStr) {
	var circleRadius = 5,
	isInside = "",
	coordX = undefined,
	coordY = undefined,
	coordXSquared = undefined,
	coordYSquared = undefined,
	radiusSquared = circleRadius * circleRadius;
	
	if ((coordXStr && (coordXStr % 1 === 0 || coordXStr % 1 !== 0)) && 
		(coordYStr && (coordYStr % 1 === 0 || coordYStr % 1 !== 0))){
		coordX = Number(coordXStr);
		coordY = Number(coordYStr);	
		
		if (isNaN(coordX) || isNaN(coordY)) {
			isInside = "incorrect input";
		} else {
			coordXSquared = coordX * coordX;
			coordYSquared = coordY * coordY;
		 
			if (coordXSquared + coordYSquared < radiusSquared) {
				isInside = "point is inside the circle with r = " + circleRadius;
			} else if (coordXSquared + coordYSquared == radiusSquared) {
				isInside = "point is on the circle with r = " + circleRadius;
			} else {
				isInside = "point is outside the cirlce with r = " + circleRadius;
			}
		}
	} else {
		isInside = "incorrect input";
	}
	
	return isInside;
}