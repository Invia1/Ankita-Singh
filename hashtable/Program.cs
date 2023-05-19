using System;
using System.Collections;


namespace HashTable
{
    class demo
    {

        static public void Main()
        {
            Hashtable my_ht1 = new Hashtable();

            my_ht1.Add("A1", "Welcome");
            my_ht1.Add("A2", "in");
            my_ht1.Add("A3", "development");

            Console.WriteLine("Key and Value pairs from my_hashtable1:");

            foreach (DictionaryEntry ele1 in my_ht1)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
            }

            /*Hashtable my_ht2 = new Hashtable()
            {
                                        {1, "hello"},
                                        {2, world},
                                        {3, ....},
                                        {4, null}
            };

            Console.WriteLine("Key and Value pairs from my_hashtable2:");

            foreach (var ele2 in my_ht 2.Keys)
            {
                Console.WriteLine("{0}and {1}", ele2,
                                my_ht2[ele2]);
            }*/
        }
    }

}