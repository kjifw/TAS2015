using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;

namespace HTMLRenderer
{
    public interface IElement
    {
        string Name { get; }
        string TextContent { get; set; }
        IEnumerable<IElement> ChildElements { get; }
        void AddElement(IElement element);
        void Render(StringBuilder output);
        string ToString();
    }

    public interface ITable : IElement
    {
        int Rows { get; }
        int Cols { get; }
        IElement this[int row, int col] { get; set; }
    }

    public interface IElementFactory
    {
        IElement CreateElement(string name);
        IElement CreateElement(string name, string content);
        ITable CreateTable(int rows, int cols);
    }

    public class HTMLElementFactory : IElementFactory
    {
        public IElement CreateElement(string name)
        {
            return new Element(name);
        }

        public IElement CreateElement(string name, string content)
        {
            return new Element(name, content);
        }

        public ITable CreateTable(int rows, int cols)
        {
            return new Table(rows, cols);
        }
    }

    public class HTMLRendererCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using HTMLRenderer;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }


    public class Element : IElement
    {
        private string name;
        private string textContent;
        private IEnumerable<IElement> childElements;

        public Element(string name, string content = null)
        {
            this.Name = name;
            this.TextContent = content;

            this.childElements = new List<IElement>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public string TextContent
        {
            get
            {
                return this.textContent;
            }
            set
            {
                this.textContent = value;
            }
        }

        public IEnumerable<IElement> ChildElements
        {
            get
            {
                return this.childElements;
            }
        }

        public void AddElement(IElement element)
        {
            List<IElement> elements = new List<IElement>();
            elements.Add(element);

            this.childElements = elements;
        }

        public virtual void Render(StringBuilder output)
        {
            if (this.Name != null)
            {
                output.Append("<" + this.Name + ">");
            }

            if (this.TextContent != null)
            {
                output.Append(this.TextContent);
            }

            foreach (var item in this.ChildElements)
            {
                item.Render(output);
            }

            if (this.Name != null)
            {
                output.Append("</" + this.Name + ">");
            }
        }

        public override string ToString()
        {
            StringBuilder elementInfo = new StringBuilder();

            this.Render(elementInfo);

            return elementInfo.ToString();
        }
    }

    public class Table : Element, ITable
    {
        private int rows;
        private int cols;
        private IElement[,] matrix;

        public Table(int rows, int cols, string name = null, string content = null)
            : base(name, content)
        {
            this.Rows = rows;
            this.Cols = cols;

            this.matrix = new IElement[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                this.cols = value;
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        public override void Render(StringBuilder output)
        {
            output.Append("<table>");

            for (int i = 0; i < this.Rows; i++)
            {
                output.Append("<tr>");

                for (int j = 0; j < this.Cols; j++)
                {
                    if (matrix[i,j] == null)
                    {
                        continue;
                    }

                    output.Append("<td>");
                    output.Append(matrix[i, j]);
                    output.Append("</td>");
                }

                output.Append("</tr>");
            }

            output.Append("</table>");
        }
    }
}
