"use strict";

function getVarTypes () {
	var allVariables = generateVariables();
	var allVariablesTypesStr = "";

	for (var i = 0; i < allVariables.length; i++) {
		allVariablesTypesStr += allVariables[i] + " --> " + typeof allVariables[i] + "<br />";
	};

	return allVariablesTypesStr;
}