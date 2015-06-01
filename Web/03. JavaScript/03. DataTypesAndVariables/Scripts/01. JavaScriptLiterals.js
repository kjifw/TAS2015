"use strict";

function jsLiterals() {

	var allVariables = generateVariables();

	var allVariablesAsStr = "";

	for (var i = 0; i < allVariables.length; i+=1) {
		if (typeof allVariables[i] === null) {
			allVariablesAsStr += "null" + "<br />";
		} else if (typeof allVariables[i] === undefined) {
			allVariablesAsStr += "undefined" + "<br />";
		} else if (Array.isArray(allVariables[i])) {
			var innerArrAsStr = "";			
			for (var j = 0; j < allVariables[i].length; j+=1) {
				innerArrAsStr += allVariables[i][j] + " ";
			};
			allVariablesAsStr += innerArrAsStr + "<br />";
		} else if (allVariables[i] instanceof Object) {
			for (var propName in allVariables[i]) {
				allVariablesAsStr += propName + " " + allVariables[i][propName] + " ";
			}
			allVariablesAsStr += "<br />";
		} else {
			allVariablesAsStr += allVariables[i] + "<br />";
		}
	};

	return allVariablesAsStr;
}

function generateVariables () {
	var int = 4;
	var float = 3.4;
	var string = "string";
	var nullValue = null;
	var undefinedValue = undefined;
	var bool = true;
	var arr = [1, 2, 3];
	var car = { type: "BMW", model: "z3" };

	var allVariables = [int, float, string, bool, nullValue, undefinedValue, arr, car];

	return allVariables;
}