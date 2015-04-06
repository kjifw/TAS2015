using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;

namespace SoftwareAcademy
{
    public interface ITeacher
    {
        string Name { get; set; }
        void AddCourse(ICourse course);
        string ToString();
    }

    public interface ICourse
    {
        string Name { get; set; }
        ITeacher Teacher { get; set; }
        void AddTopic(string topic);
        string ToString();
    }

    public interface ILocalCourse : ICourse
    {
        string Lab { get; set; }
    }

    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }

    public interface ICourseFactory
    {
        ITeacher CreateTeacher(string name);
        ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab);
        IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town);
    }

    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            ITeacher teacher = new Teacher(name);

            return teacher;
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            ILocalCourse localCourse = new LocalCourse(name, teacher, lab);

            return localCourse;
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            IOffsiteCourse offsiteCourse = new OffsiteCourse(name, teacher, town);

            return offsiteCourse;
        }
    }

    public class SoftwareAcademyCommandExecutor
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
                  using SoftwareAcademy;

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

    public class Course : ICourse
    {
        private string name;
        private ITeacher teacher;
        private List<string> topics;

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                this.teacher = value;
            }
        }

        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder courseInfo = new StringBuilder();

            courseInfo.AppendFormat("{0}: ", this.GetType().Name);
            courseInfo.AppendFormat("Name={0}", this.Name);

            if (this.Teacher != null)
            {
                courseInfo.AppendFormat("; Teacher={0}", this.Teacher.Name);
            }

            if (this.topics.Count != 0)
            {
                courseInfo.Append("; Topics=[");

                for (int i = 0; i < this.topics.Count; i++)
                {
                    if (i != this.topics.Count - 1)
                    {
                        courseInfo.AppendFormat("{0}, ", this.topics[i]);
                    }
                    else
                    {
                        courseInfo.AppendFormat("{0}", this.topics[i]);
                    }
                }

                courseInfo.Append("]");
            }

            return courseInfo.ToString();
        }
    }

    public class LocalCourse : Course, ILocalCourse
    {
        private string lab;

        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder localCourseInfo = new StringBuilder();

            localCourseInfo.Append(base.ToString());
            localCourseInfo.AppendFormat("; Lab={0}", this.Lab);

            return localCourseInfo.ToString();
        }
    }

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder offsiteCourseInfo = new StringBuilder();

            offsiteCourseInfo.Append(base.ToString());
            offsiteCourseInfo.AppendFormat("; Town={0}", this.Town);

            return offsiteCourseInfo.ToString();
        }
    }

    public class Teacher : ITeacher
    {
        private string name;
        private List<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder teacherInfo = new StringBuilder();

            teacherInfo.Append("Teacher: ");
            teacherInfo.AppendFormat("Name={0}", this.Name);

            if (this.courses.Count > 0)
            {
                teacherInfo.Append("; Courses=[");

                for (int i = 0; i < this.courses.Count; i++)
                {
                    ICourse currentCourse = this.courses[i];

                    if (i != this.courses.Count - 1)
                    {
                        teacherInfo.AppendFormat("{0}, ", currentCourse.Name);
                    }
                    else
                    {
                        teacherInfo.AppendFormat("{0}", currentCourse.Name);
                    }
                }

                teacherInfo.Append("]");
            }

            return teacherInfo.ToString();
        }
    }
}
