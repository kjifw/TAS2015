function solveTask (currentTaskNumber) {
	document.getElementById("userButton").addEventListener("click", function() { 
		if (currentTaskNumber == 1) {
			divTaskSolution.innerHTML = jsLiterals();
		} else if (currentTaskNumber == 2) {			
			divTaskSolution.innerHTML = getQuotedText();
		} else if (currentTaskNumber == 3) {	
			divTaskSolution.innerHTML = getVarTypes();
		} else if (currentTaskNumber == 4) {
			divTaskSolution.innerHTML = getNullUndefined();
		}
	});
}