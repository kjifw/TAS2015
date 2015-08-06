function solve(){
    return function(){
        $.fn.listview = function(data){
            var $this = $(this);
            var selector = '#' + $this.attr('data-template');
            var templateHtml = $(selector).html();
            var template = handlebars.compile(templateHtml);

            for(var i = 0; i < data.length; i += 1) {
                $this.append(template(data[i]));
            }

            return this;
        };
    };
}

module.exports = solve;