// For task condition please refer to https://github.com/TelerikAcademy/JavaScript-Fundamentals/tree/master/11.%20Strings
"use strict";

var text = "My new email is fake@mail.rr in the new rr domain.\
There is no turning back now. Create your abc@def.gh.";

console.log(text);

function extractEmails(text) {
	var email,
		extracted = "",
		regexMail = /([A-z0-9._]{2,})@([A-z0-9._]{2,})\.([A-z0-9.]{2,})/;

	while(true) {
		email = regexMail.exec(text);
		
		if (email == null || email == undefined) {
			break;
		}
		
		text = text.replace(regexMail, "");
		extracted += email[0] + "; ";
	}

	return extracted;
}

var result = extractEmails(text);

console.log(result);