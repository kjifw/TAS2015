"use strict";

var divTaskCondition = document.getElementById("taskCondition");
var divTaskSolution = document.getElementById("taskSolution");
var divTaskControls = document.getElementById("taskControls");

function loadTask01 () {
	divTaskCondition.innerHTML = "Problem 1. JavaScript literals<br /> \
	* Assign all the possible JavaScript literals to different variables.";	
	
	divTaskControls.innerHTML = "";
	divTaskSolution.innerHTML = "";
	
	generateUserControlsForTask(1);
	solveTask(1);
}

function loadTask02 () {
	divTaskCondition.innerHTML = "Problem 2. Quoted text<br /> \
	* Create a string variable with quoted text in it.<br /> \
	* For example: \"How you doin'?\", Joey said.";	
	
	divTaskControls.innerHTML = "";
	divTaskSolution.innerHTML = "";
	
	generateUserControlsForTask(2);
	solveTask(2);
}

function loadTask03 () {
	divTaskCondition.innerHTML = "Problem 3. Typeof variables<br /> \
	* Try typeof on all variables you created.";	
	
	divTaskControls.innerHTML = "";
	divTaskSolution.innerHTML = "";
	
	generateUserControlsForTask(3);
	solveTask(3);
}

function loadTask04 () {
	divTaskCondition.innerHTML = "Problem 4. Typeof null<br /> \
	* Create null, undefined variables and try typeof on them.";	
	
	divTaskControls.innerHTML = "";
	divTaskSolution.innerHTML = "";
	
	generateUserControlsForTask(4);
	solveTask(4);
}