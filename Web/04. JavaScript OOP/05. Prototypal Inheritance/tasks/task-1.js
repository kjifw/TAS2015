/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/


/* Example

var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)

var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {
  var domElement = (function () {
    var domElement = {
      init: function (type) {
        this.type = type;
        this.attributes = [];
        this.content = "";
        this.parent;
        this.children = [];
        return this;
      },
      appendChild: function (child) {
        this.children.push(child);
        child.parent = this;
        return this;
      },
      addAttribute: function (name, value) {
        if (name === "") {
          throw new Error();
        }

        if (!/^[A-Za-z0-9-]+$/.test(name)) {
          throw new Error();
        }

        this.attributes[name] = value;
        return this;
      },
      removeAttribute: function (name) {
        var attr = this.attributes[name];
        if (!attr) {
          throw new Error();
        }
        delete this.attributes[name];
        return this;
      },
      get innerHTML() {
        var result = "";

        result += "<" + this.type + " ";
        result += sortAttributes(this.attributes);
        result = result.trim();
        result += ">";

        if (this.children.length > 0) {
          for (var childrenIndex = 0; childrenIndex < this.children.length; childrenIndex += 1) {
            var currentChild = this.children[childrenIndex];
            if (typeof (currentChild) === "string") {
              result += currentChild;
            } else {
              result += currentChild.innerHTML;
            }
          }
        } else {
          result += this.content;
        }

        result += "</" + this.type + ">";

        return result;
      }
    };

    function sortAttributes(attributes) {
      var result = "",
        keys = [],
        len,
        key,
        i,
        currentKey;

      for (key in attributes) {
        keys.push(key);
      }

      keys.sort();
      len = keys.length;

      for (i = 0; i < len; i += 1) {
        currentKey = keys[i];
        result += currentKey + "=\"" + attributes[currentKey] + "\" ";
      }

      return result;
    }

    Object.defineProperty(domElement, "content", {
      get: function () {
        return this._content;
      },
      set: function (value) {
        if (typeof (value) !== "string") {
          throw new Error();
        }
        this._content = value;
        return this;
      }
    });

    Object.defineProperty(domElement, "type", {
      get: function () {
        return this._type;
      },
      set: function (value) {
        if (typeof (value) !== "string") {
          throw new Error();
        }
        if (!/^[A-Za-z0-9]+$/.test(value)) {
          throw new Error();
        }
        if (value === "") {
          throw new Error();
        }

        this._type = value;
        return this;
      }
    });

    return domElement;
  } ());
  return domElement;
}

module.exports = solve;
