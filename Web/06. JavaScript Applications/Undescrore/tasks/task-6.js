/* 
Create a function that:
*   **Takes** a collection of books
    *   Each book has propeties `title` and `author`
        **  `author` is an object that has properties `firstName` and `lastName`
*   **finds** the most popular author (the author with biggest number of books)
*   **prints** the author to the console
	*	if there is more than one author print them all sorted in ascending order by fullname
		*   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
    return function (books) {
        var result = _.chain(books)
        .map(function(book) {
            book.author.fullName = book.author.firstName + ' ' + book.author.lastName;
            return book;
        })
        .countBy(function(book) {
            return book.author.fullName;
        })
        .pairs()
        .sortBy(1)
        .reverse();

        var resStrArr = result.toString().split(",");
        var topAuthors = [];
        
        topAuthors.push(resStrArr[0]);

        for (var i = 2; i <= resStrArr.length - 2; i += 2) {
            if (resStrArr[i + 1] === resStrArr[1]) {
                topAuthors.push(resStrArr[i]);
            } else {
                break;
            }
        }

        _.chain(topAuthors)
        .sortBy(0)
        .each(console.log);
    };
}

module.exports = solve;
