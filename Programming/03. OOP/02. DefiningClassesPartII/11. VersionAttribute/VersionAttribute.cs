
namespace _11.VersionAttribute
{
    using System;

    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Struct |
        AttributeTargets.Interface |
        AttributeTargets.Method |
        AttributeTargets.Enum, AllowMultiple = true)]

    public class VersionAttribute : System.Attribute
    {
        public int MajorVersion { get; private set; }
        public int MinorVersion { get; private set; }

        public VersionAttribute(int major, int minor)
        {
            this.MajorVersion = major;
            this.MinorVersion = minor;
        }

        public override string ToString()
        {
            string result = this.MajorVersion.ToString() + "." + this.MinorVersion.ToString();

            return result;
        }
    }
}
