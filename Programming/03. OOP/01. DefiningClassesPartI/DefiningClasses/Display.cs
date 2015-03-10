
namespace DefiningClasses
{
    using System;
    using System.Text;

    public class Display
    {
        private int size;
        private int numberOfColors;

        public Display()
            :this(0, 0)
        {
 
        }

        public Display(int size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public int Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Display size must be positive");
                }

                this.size = value;
            }
        }
        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of colors must be positive");
                }

                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            StringBuilder displayInfo = new StringBuilder();

            displayInfo.AppendLine("Display information: ");
            displayInfo.AppendFormat("Display size: {0}\n", this.Size);
            displayInfo.AppendFormat("Number of colors: {0}\n", this.NumberOfColors);

            return displayInfo.ToString();
        }
    }
}
