/* globals $ */

/* 

Create a function that takes an id or DOM element and:
* If an id is provided, select the element
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided DOM element is non-existant
  * The id is either not a string or does not select any DOM element

  */

  function solve(){
  	return function (selector) {
  		var element;

  		if (selector === undefined || selector === null) {
  			throw new Error("Selector cannot be null or undefined.");
  		}

  		if (typeof selector === "string") {
  			selector = document.getElementById(selector);
  		}

  		if (!(selector instanceof HTMLElement)) {
  			throw new Error("Selector must be valid html element.");
  		}

  		element = selector;

  		var items = element.querySelectorAll(".button");

        if (items.length > 0) {
            for (var i = 0; i < items.length; i+=1) {
                items[i].innerHTML = "hide";
            }
        }

        element.addEventListener("click", function (event) {
            var target = event.target;
            var value;

            if (target.classList.contains("button")) {
                if (target.innerHTML === "hide") {
                    target.innerHTML = "show";
                    value = "none";
                } else {
                    target.innerHTML = "hide";
                    value = "";
                }

                switchElementState();
            }

            function switchElementState () {
                var current = target;

                while(true) {
                    if (current instanceof HTMLElement) {
                        if (current.classList.contains("button")) {
                            current.innerHTML = target.innerHTML;
                        }
                        
                        if (current.classList.contains("content")) {
                            current.style.display = value;
                            break;
                        } 
                    }

                    current = current.nextSibling;

                    if (current === undefined || current === null) {
                        break;
                    }
                }                

                current = target;

                while(true) {
                    if (current instanceof HTMLElement) {
                        if (current.classList.contains("button")) {
                            current.innerHTML = target.innerHTML;
                        } else {
                            break;
                        }
                    }

                    current = current.previousSibling;

                    if (current === undefined || current === null) {
                        break;
                    }
                }
            }
        });
    };
};

module.exports = solve;