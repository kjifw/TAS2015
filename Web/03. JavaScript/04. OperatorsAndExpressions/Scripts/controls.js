"use strict";

function generateUserControlsForTask (currentTask) {
	var userButton = document.createElement("input");
	userButton.type = "button";
	userButton.value = "Solve Task";
	userButton.id = "userButton";
	userButton.style.margin = "0 5px";

	if (currentTask != 3 && currentTask != 6 && currentTask != 8 && currentTask != 9) {
		var userInput = document.createElement("input");
		userInput.type = "text";
		userInput.id = "userInput";

		divTaskControls.appendChild(userInput);
	} else {
		var userFirstInput = document.createElement("input");
		userFirstInput.type = "text";
		userFirstInput.id = "userFirstInput";

		var labelFirstInput = document.createElement("Label");
		labelFirstInput.for = "userFirstInput";

		var userSecondInput = document.createElement("input");
		userSecondInput.type = "text";
		userSecondInput.id = "userSecondInput";

		var labelSecondInput = document.createElement("Label");
		labelSecondInput.for = "userSecondInput";

		if (currentTask == 3) {
			labelFirstInput.innerHTML = "width: ";
			labelSecondInput.innerHTML = "height: ";
		}

		if (currentTask == 6 || currentTask == 9) {
			labelFirstInput.innerHTML = "x: ";
			labelSecondInput.innerHTML = "y: ";
		}

		if (currentTask == 8) {
			labelFirstInput.innerHTML = "a: ";
			labelSecondInput.innerHTML = "b: ";  
		}

		divTaskControls.appendChild(labelFirstInput);
		divTaskControls.appendChild(userFirstInput);
		divTaskControls.appendChild(labelSecondInput);
		divTaskControls.appendChild(userSecondInput);

		if (currentTask == 8) {
			var userThirdInput = document.createElement("input");		
			userThirdInput.type = "text";
			userThirdInput.id = "userThirdInput";
			
			var labelThirdInput = document.createElement("Label");
			labelThirdInput.for = "userThirdInput";
			labelThirdInput.innerHTML = "h: ";

			divTaskControls.appendChild(labelThirdInput);
			divTaskControls.appendChild(userThirdInput);
		}
	}

	divTaskControls.appendChild(userButton);
}