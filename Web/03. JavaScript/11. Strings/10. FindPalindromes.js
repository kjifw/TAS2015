// For task condition please refer to https://github.com/TelerikAcademy/JavaScript-Fundamentals/tree/master/11.%20Strings
"use strict";

var text = "Lorem ipsum dolod tit amet, consectetur adipiscing elit. \
Aenean consequat id lorol sed varius. Fusce egestas dictum nunc et mollis. \
Donec elementum libero velit, teget ullamcorper est maximus ut. \
Suspendisse condimentum lamal pellentesque lebel et porttitor. Aenean ut semper eros.";

console.log(text);

function findPalindromes(text) {
	var currentWord,
		right,
		count = 0,
	 	textArr = text.split(/[\s,.?!]+/),
	 	palindromes = "palindromes: ";

	for (var i = 0; i < textArr.length; i+=1) {
		currentWord = textArr[i];
		count = 0;

		right = currentWord.length - 1;
		for (var left = 0; left < currentWord.length; left+=1) {
			if (currentWord[left] == currentWord[right]) {
				count+=1;
			}
			right-=1;
		}

		if (count == currentWord.length) {
			palindromes += currentWord + " ";
		}
	}

	return palindromes;
}

var result = findPalindromes(text);
console.log();
console.log(result);