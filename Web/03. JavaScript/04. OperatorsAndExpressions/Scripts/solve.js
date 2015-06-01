"use strict";

function solveTask (currentTaskNumber) {
	document.getElementById("userButton").addEventListener("click", function() {
		if (currentTaskNumber != 3 && currentTaskNumber != 6  && currentTaskNumber != 8 && currentTaskNumber != 9) {
			var inputStr = document.getElementById("userInput").value;
			if (currentTaskNumber == 1) {
				divTaskSolution.innerHTML = oddOrEven(inputStr);
			} else if (currentTaskNumber == 2) {
				divTaskSolution.innerHTML = divisibleBySevenAndFive(inputStr);
			} else if (currentTaskNumber == 4) {
				divTaskSolution.innerHTML = findThirdDigit(inputStr);
			} else if (currentTaskNumber == 5) {
				divTaskSolution.innerHTML = findThirdBit(inputStr);
			} else if (currentTaskNumber == 7) {
				divTaskSolution.innerHTML = isPrimeNumber(inputStr);
			}
		} else {
			var firstValue = document.getElementById("userFirstInput").value;
			var secondValue = document.getElementById("userSecondInput").value;

			if (currentTaskNumber == 3) {
				divTaskSolution.innerHTML = calculateRectArea(firstValue, secondValue);
			}

			if (currentTaskNumber == 6) {
				divTaskSolution.innerHTML = pointIsInsideCircle(firstValue, secondValue);
			}

			if (currentTaskNumber == 8) {
				var thirdValue = document.getElementById("userThirdInput").value;
				divTaskSolution.innerHTML = calculateTrapezoidArea(firstValue, secondValue, thirdValue);
			}

			if (currentTaskNumber == 9) {
				divTaskSolution.innerHTML = isInsideFigures(firstValue, secondValue);
			}
		}
	});
}