"use strict";

function generateUserControlsForTask (currentTask) {
	var userButton = document.createElement("input");
	
	userButton.type = "button";
	userButton.value = "Solve Task";
	userButton.id = "userButton";

	divTaskControls.appendChild(userButton);
}