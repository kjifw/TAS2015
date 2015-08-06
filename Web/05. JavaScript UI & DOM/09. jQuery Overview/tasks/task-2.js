/* globals $ */

/*
Create a function that takes a selector and:
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
  * The provided ID is not a **jQuery object** or a `string` 

  */
function solve(selector) {
    return function (selector) {
        if (selector === undefined || selector === null) {
            throw new Error("Selector cannot be null or undefined.");
        }
        
        if (typeof selector !== "string") {
            throw new Error("Selector must be string");
        }

        var $selector = $(selector);

        if ($selector.length === 0) {
            throw new Error();
        }

        $selector
            .children(".button")
            .text("hide");

        $selector
            .on("click", ".button", function () {
                var $this = $(this);
                if ($this.html() === "hide") {                          
                    $this
                        .html("show")
                        .nextAll(".content")
                        .first()
                        .css("display", "none");
                } else {                  
                    $this
                        .html("hide")
                        .nextAll(".content")
                        .first()
                        .css("display", "");
                }
            });
    };
};
module.exports = solve;