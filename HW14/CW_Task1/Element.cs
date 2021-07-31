using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Task1
{
    public class Element
    {
        private int value1;
        private int value2;
        private int value3;

        public Element(int val1, int val2, int val3)
        {
            value1 = val1;
            value2 = val2;
            value3 = val3;
        }

        public int Value1
        {
            get { return value1; }
            set { value1 = value; }
        }
        public int Value2
        {
            get { return value2; }
            set { value2 = value; }
        }
        public int Value3
        {
            get { return value3; }
            set { value3 = value; }
        }
    }
}
