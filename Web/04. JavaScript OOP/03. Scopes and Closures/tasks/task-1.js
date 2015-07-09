/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, 
				digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/

function solve() {
	"use strict";
	
	var library = (function () {
		var books = [];
		var categories = [];

		function listBooks() {
			var currentArgument;
			
			if (arguments.length > 0) {
				currentArgument = arguments[0];
				if (typeof currentArgument.category !== "undefined") {
					if (typeof categories[currentArgument.category] !== "undefined") {
						return categories[currentArgument.category];
					} else  {
						return [];
					}
				} else if(typeof currentArgument.author !== "undefined") {
					if (typeof categories[currentArgument.author] !== "undefined") {
						return categories[currentArgument.author];
					} else  {
						return [];
					}
				} else {
					return books;
				}
			}
			
			return books;
		}

		function addBook(book) {
			book.ID = books.length + 1;

			if (book.title.length < 2 || book.title.length > 100 ||
				book.category.length < 2 || book.category.length > 100) {
				throw new Error();
			}

			if (book.author.trim() === "") {
				throw new Error();
			}

			if (book.isbn.length !== 10 && book.isbn.length !== 13) {
				throw new Error();
			}

			if (!/^\d+$/.test(book.isbn.toString())) {
				throw new Error();
			}

			for (var i = 0, len = books.length; i < len; i += 1) {
				if (books[i].title === book.title ||
					books[i].isbn === book.isbn) {
					throw new Error();
				}
			}	
			
			if (categories.indexOf(book.category) < 0) {
				categories[book.category] = [];		
			}	
			
			categories[book.category].push(book);			
			books.push(book);

			return book;
		}

		function listCategories() {
			var categoriesList = [];
            
			for (var key in categories) {
				categoriesList.push(key);
			}
			
			return categoriesList;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());

	return library;
}

module.exports = solve;
