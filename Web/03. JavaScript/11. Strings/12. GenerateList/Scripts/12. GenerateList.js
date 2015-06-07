// For task condition please refer to https://github.com/TelerikAcademy/JavaScript-Fundamentals/tree/master/11.%20Strings
"use strict";

var template = document.getElementById("list-item").innerHTML,
	people = [		
	new Human("petar petrov", 25),
	new Human("georgi toshev", 23),
	new Human("maria pesheva", 19),
	new Human("nikolay petrov", 17),
	new Human("kalina kirova", 18),
	new Human("ivan ivanov", 22),
	new Human("petko petkov", 21),
	new Human("teodora todorova", 23),
	new Human("dimitar dimitrov", 25),
	new Human("antonia atanasova", 24)
];

generateList();

function generateList() {
	var li,
	 	ul = document.createElement("ul");

	for (var i in people) {
		li = document.createElement("li");
		li.innerHTML = formatString(template, people[i]);
		ul.appendChild(li);
	}

	document.body.appendChild(ul);
}

function formatString (template, str) {
	var currentTemplateAttr,
		regex = /-{(.*?)}-/;
		
	while(true) {	
		currentTemplateAttr = regex.exec(template);
		
		if (currentTemplateAttr == null || currentTemplateAttr == undefined) {
			break;
		}
		
		template = template.replace(currentTemplateAttr[0], str[currentTemplateAttr[1]]);
	}

	return template;
}

function Human (name, age) {
	this.name = name;
	this.age = age;
	this.toString = function() {
		return this.name + " " + this.age;
	}
}
