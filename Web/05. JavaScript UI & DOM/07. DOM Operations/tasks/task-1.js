/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

	return function (element, contents) {
		var el,
			div,
			docFrag;

		if (element === undefined || element === null) {
			throw new Error("Element cannot be null or undefined.");
		}

		if (typeof element === "string") {
			element = document.getElementById(element);
		} 

		if (!(element instanceof HTMLElement)) {
			throw new Error("Element is not valid html element.");
		}

		if (!(Array.isArray(contents))) {
			throw new Error("Contents cannot be array.");
		}	

		contents.forEach(function (item) {
			if (typeof item !== "string" && typeof item !== "number") {
				throw new Error("Contents must contain only string or number.");
			}
		});

		div = document.createElement("div");	
		docFrag = document.createDocumentFragment();

		el = element;
		el.innerHTML = "";

		for (var i = 0, len = contents.length; i < len; i += 1) {
			currentDiv = div.cloneNode(true);
			currentDiv.innerHTML = contents[i];
			docFrag.appendChild(currentDiv);
		}

		el.appendChild(docFrag);

		return el;
	};
};