using System.Collections;

namespace HW_Task1
{
    class MyClassCollection
    {
        public string[] strArr = new string[10];

        public IEnumerable GetEvenIndexValues()
        {
            string[] strTemp = new string[0];

            var myClassCollection = new MyClassCollection();
            for (int i = 0; i < strArr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    yield return strArr[i];
                }
            }
        }

        public IEnumerable GetOddIndexValues()
        {
            string[] strTemp = new string[0];

            var myClassCollection = new MyClassCollection();
            for (int i = 0; i < strArr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    yield return strArr[i];
                }
            }
        }
    }
}
