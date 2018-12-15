using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace OOP1
{
    public class Display
    {
        private int size;
        private int numberofcolors;

        public int Numberofcolors
        {
            get { return numberofcolors; }
            set { numberofcolors = value; }
        }


        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public override string ToString()
        {
            StringBuilder displayy = new StringBuilder();
            if (this.size == 0)
            {
                displayy.AppendLine("No certain display");

            }
            else
            {
                displayy.AppendLine(string.Format("size: {0}", this.Size));
                displayy.AppendLine(string.Format("numberofcolors: {0}", this.Numberofcolors));

            }
            return displayy.ToString();
        }

    }
}
