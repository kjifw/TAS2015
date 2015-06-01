"use strict";

var divTaskCondition = document.getElementById("taskCondition");
var divTaskSolution = document.getElementById("taskSolution");
var divTaskControls = document.getElementById("taskControls");

function loadTask01 () {
	divTaskCondition.innerHTML = "Problem 1. Odd or Even <br />\
	* Write an expression that checks if given integer is odd or even.<br />\
	* Examples: <br />\
	n 	Odd? <br />\
	3 	true <br />\
	2 	false <br />\
	-2 	false <br />\
	-1 	true <br />\
	0 	false";
	
	clearElements();	
	generateUserControlsForTask(1);
	solveTask(1);
}

function loadTask02 () {
	divTaskCondition.innerHTML = "Problem 2. Divisible by 7 and 5 <br />\
	* Write a boolean expression that checks for given integer if it can be divided \
	(without reminder) by 7 and 5 in the same time.<br />\
	* Examples: <br />\
	n 	Divided by 7 and 5?<br />\
	3 	false <br />\
	0 	true <br />\
	5 	false <br />\
	7 	false <br />\
	35 	true <br />\
	140 true";
	
	clearElements();	
	generateUserControlsForTask(2);
	solveTask(2);
}

function loadTask03 () {
	divTaskCondition.innerHTML = "Problem 3. Rectangle area<br /> \
	* Write an expression that calculates rectangle's area by given width and height.";	
	
	clearElements();	
	generateUserControlsForTask(3);
	solveTask(3);
}

function loadTask04 () {
	divTaskCondition.innerHTML = "Problem 4. Third digit<br /> \
	* Write an expression that checks for given integer if its third digit (right-to-left) is 7.";	
	
	clearElements();	
	generateUserControlsForTask(4);
	solveTask(4);
}

function loadTask05 () {
	divTaskCondition.innerHTML = "Problem 5. Third bit<br /> \
	* Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer. <br />\
	* The bits are counted from right to left, starting from bit #0. <br />\
	* The result of the expression should be either 1 or 0.";	
	
	clearElements();	
	generateUserControlsForTask(5);
	solveTask(5);
}

function loadTask06 () {
	divTaskCondition.innerHTML = "Problem 6. Point in Circle<br />\
	* Write an expression that checks if given point P(x, y) is within\
	a circle K({0, 0}, 5). {0, 0} is the center and 5 is the radius.<br />\
	* Examples: <br />\
	x y inside <br />\
	0 1 true<br />\
	-5 0 true <br />\
	-4 5 false <br />\
	1.5 -3 true <br />\
	-4 -3.5 false <br />\
	100 -30 false <br />\
	0 0 true <br />\
	0.2 -0.8 true <br />\
	0.9 -4.93 false <br />\
	2 2.655 true";	
	
	clearElements();	
	generateUserControlsForTask(6);
	solveTask(6);
}

function loadTask07 () {
	divTaskCondition.innerHTML = "Problem 7. Is Prime<br />\
	* Write an expression that checks if given positive integer number n (n <= 100) is prime.<br />\
	* Examples: <br />\
	n Prime? <br />\
	1 false <br />\
	2 true <br />\
	3 true <br />\
	4 false <br />\
	9 false <br />\
	37 true <br />\
	97 true <br />\
	51 false <br />\
	-3 false <br />\
	0 false";	
	
	clearElements();	
	generateUserControlsForTask(7);
	solveTask(7);
}

function loadTask08 () {
	divTaskCondition.innerHTML = "Problem 8. TrapezoidArea<br />\
	* Write an expression that calculates trapezoid's area by given sides a and b and height h<br />\
	* Examples: <br />\
	<table>\
		<tr>\
			<td>a</td>\
			<td>b</td>\
			<td>h</td>\
			<td>area</td>\
		</tr>\
		<tr>\
			<td>5</td>\
			<td>7</td>\
			<td>12</td>\
			<td>72</td>\
		</tr>\
		<tr>\
			<td>2</td>\
			<td>1</td>\
			<td>33</td>\
			<td>49.5</td>\
		</tr>\
		<tr>\
			<td>8.5</td>\
			<td>4.3</td>\
			<td>2.7</td>\
			<td>17.28</td>\
		</tr>\
		<tr>\
			<td>100</td>\
			<td>200</td>\
			<td>300</td>\
			<td>45000</td>\
		</tr>\
		<tr>\
			<td>0.222</td>\
			<td>0.333</td>\
			<td>0.555</td>\
			<td>0.1540125</td>\
		</tr>\
	</table>";
	
	clearElements();	
	generateUserControlsForTask(8);
	solveTask(8);
}

function loadTask09 () {
	divTaskCondition.innerHTML = "Problem 9. Point in Circle and outside Rectangle<br />\
	* Write an expression that checks for given point P(x, y) if it is within the circle\
	K({1, 1}, 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).<br />\
	* Examples: <br />\
	<table>\
		<tr>\
			<td>x</td>\
			<td>y</td>\
			<td>inside K & outside R</td>\
		</tr>\
		<tr>\
			<td>1</td>\
			<td>4</td>\
			<td>yes</td>\
		</tr>\
		<tr>\
			<td>3</td>\
			<td>2</td>\
			<td>yes</td>\
		</tr>\
		<tr>\
			<td>0</td>\
			<td>1</td>\
			<td>no</td>\
		</tr>\
		<tr>\
			<td>4</td>\
			<td>1</td>\
			<td>no</td>\
		</tr>\
		<tr>\
			<td>2</td>\
			<td>0</td>\
			<td>no</td>\
		</tr>\
		<tr>\
			<td>4</td>\
			<td>0</td>\
			<td>no</td>\
		</tr>\
		<tr>\
			<td>2.5</td>\
			<td>1.5</td>\
			<td>yes</td>\
		</tr>\
		<tr>\
			<td>3.5</td>\
			<td>1.5</td>\
			<td>yes</td>\
		</tr>\
		<tr>\
			<td>-100</td>\
			<td>-100</td>\
			<td>no</td>\
		</tr>\
	</table>";
	
	clearElements();	
	generateUserControlsForTask(9);
	solveTask(9);
}

function clearElements () {
	divTaskControls.innerHTML = "";
	divTaskSolution.innerHTML = "";
}