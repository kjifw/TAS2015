function solve(){
    return function(selector){
        if (selector === undefined || selector === null) {
            throw new Error("Selector cannot be null or undefined.");
        }          

        if (typeof selector !== "string") {
            throw new Error("Selector must be string.");
        }

        $selector = $(selector);

        var $dropdownDiv = $("<div />")
                                .addClass("dropdown-list");
        var $currentDiv = $("<div />")
                                .addClass("current");
        var $divContainer = $("<div />")
                                .addClass("options-container")
                                .css("position", "absolute");        

        var $div;

        for (var i = 0; i < $selector.children().length; i += 1) {
            $div = $("<div />")
                        .addClass("dropdown-item")
                        .attr("data-value", "value-" + (i + 1))
                        .attr("data-index", i)
                        .text("Option " + (i + 1))
                        .appendTo($divContainer);
        }

        if ($div !== undefined) {
            $currentDiv.html($div.html());
        }

        $divContainer.hide();

        $dropdownDiv
            .on("click", ".dropdown-item", function (event) {
                $currentDiv.html($(event.target).html());        
                $selector.val($(event.target).attr("data-value"));
                $divContainer.hide();
            });

        $dropdownDiv
            .on("click", ".current", function () {
                $currentDiv.html("Select Option");
                $divContainer.show(); 
            });

        $selector.appendTo($dropdownDiv);        
        $selector.hide();
        $currentDiv.appendTo($dropdownDiv);
        $divContainer.appendTo($dropdownDiv);
        $dropdownDiv.appendTo("body");
    };
};

module.exports = solve;