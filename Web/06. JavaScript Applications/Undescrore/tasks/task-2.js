/*
Create a function that:
*   Takes an array of students
    *   Each student has a `firstName`, `lastName` and `age` properties
*   **finds** the students whose age is between 18 and 24
*   **prints**  the fullname of found students, sorted lexicographically ascending
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  return function (students) {
    const MIN_AGE = 18,
          MAX_AGE = 24;

    _.chain(students)
    .filter(function(student) {
        var validateAge = MIN_AGE <= student.age && student.age <= MAX_AGE;
        return validateAge;
    })
    .map(function(student) {
        student.fullName = student.firstName + ' ' + student.lastName;
        return student;
    })
    .sortBy(function(student) {
        return student.fullName;
    })
    .each(function(student) {
        console.log(student.fullName);
    });
  };
}

module.exports = solve;
