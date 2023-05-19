using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        HashSet<Object> list = new HashSet<Object>();
        object[] item = new object[5];

        public object this[int i]
        {
            get
            {
                return item[i];
            }
            set
            {
                item[i] = value;
            }
        }
        public void AddIntegers()
        {

        }
        public static void Main(string[] args)
        {
            HashSet<Object> list = new HashSet<Object>();
            Program obj = new Program();

            list.Add(obj[0] = 1);
            list.Add(obj[1] = 2);
            list.Add(obj[2] = 3);
            list.Add(obj[3] = 1);


            foreach (int n in list)
            {
                Console.WriteLine(n);
            }
        }



    }
}