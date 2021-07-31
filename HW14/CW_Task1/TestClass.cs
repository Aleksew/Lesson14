using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Task1
{
    class TestClass : IEnumerable, IEnumerator
    {
        Element[] testArray = null;

        public TestClass()
        {
            testArray = new Element[5];

            testArray[0] = new Element(11, 12, 13);
            testArray[1] = new Element(21, 22, 23);
            testArray[2] = new Element(31, 32, 33);
            testArray[3] = new Element(41, 42, 43);
            testArray[4] = new Element(51, 52, 53);
        }

        int position = -1;

        public object Current
        {
            get { return testArray[position]; }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (position < testArray.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public void Add(Element element)
        {
            testArray = testArray.Concat(new Element[] { element }).ToArray();
        }

        public Element GetOnTheIndex(int index)
        {
            return testArray[index];
        }

        public void Remove( int index)
        {
            Element[] newArr = new Element[testArray.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArr[i] = testArray[i];
            }
            for (int i = index; i < testArray.Length; i++)
            {
                newArr[i - 1] = testArray[i];
            }
            testArray = newArr;
        }
    }
}
