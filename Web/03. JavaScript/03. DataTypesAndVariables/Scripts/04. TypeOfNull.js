"use strict";

function getNullUndefined () {
	var nullValue = null;
	var undefinedValue = undefined;
	var varTypesStr = "";

	var variableTypes = [nullValue, undefinedValue];

	for (var i = 0; i < variableTypes.length; i++) {
		varTypesStr += variableTypes[i] + " --> " + typeof variableTypes[i] + "<br />";
	};

	return varTypesStr;
}