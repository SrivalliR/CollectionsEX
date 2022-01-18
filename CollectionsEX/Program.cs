using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsEX
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array - Strongly typed - Fixed size - Cannot increase/decrease dynamically - System.Array - Store one datatype -cannot accept null
            int[] marks = new int[3];
            marks[0] = 89;
            marks[1] = 78;
            marks[2] = 99;
            Console.WriteLine("Array elements:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(marks[i]);
            }

            //ArrayList - Not strongly typed - Increase/decrease size dynamically - System.Collection - store different datatype - accepts null
            ArrayList arrList = new ArrayList();
            arrList.Add("Ajay");
            arrList.Add("Ram");
            arrList.Add(90);
            Console.WriteLine("ArrayList contains:");
            foreach (var ele in arrList)
            {
                Console.WriteLine(ele);
            }
            //Adding additional elements to the ArrayList - AddRange()
            string[] str = { "ABC", "XYZ" };
            arrList.AddRange(str);
            Console.WriteLine("After adding some elements to the ArrayList");
            foreach (var ele in arrList)
            {
                Console.WriteLine(ele);
            }

            //Dictionary - collection of Key/Value pairs - System.Collection.Generics - Store any datatype
            //Key=int, Value=string - Both will be stored in a Dictionary Object
            //Gives error if we try to find a key which is not there

            //Create a dictioanary with string key and int value pair
            Dictionary<string, int> AuthorsList = new Dictionary<string, int>();
            AuthorsList.Add("James", 56);
            AuthorsList.Add("Anand", 23);
            AuthorsList.Add("Sita", 45);

            Console.WriteLine("Sorted By value in Dictionary by using Linq OrderBy()");
            foreach (KeyValuePair<string, int> author in AuthorsList.OrderBy(key => key.Value))
            {
                Console.WriteLine("Key:{0}, Value: {1}", author.Key, author.Value);
            }

            //Hashtable - Slowerthan Dictionary
            //For Strongly typed collections, Dictionary collection is faster
            //Hashtable - collection of key/value pairs that are organized based on the hash code of the key.
            //Hashtable uses the key to access the elements in the collections - main difference - ht[k] prints the values 

            Hashtable ht = new Hashtable();
            ht.Add("EE01", "Tom");
            ht.Add("EE56", "Ram");
            ht.Add("E100", "XYZ");

            Console.WriteLine("Values in Hashtable:");
            ICollection key = ht.Keys;

            foreach(string k in key)
            {
                Console.WriteLine(k + "=" + ht[k]);
            }

            //Sets - HashSet - Eliminates duplicate strings/elements in an array - It is an optimized set collection

            HashSet<int> set1 = new HashSet<int>();
            set1.Add(10);
            set1.Add(20);
            set1.Add(30);
            set1.Add(10);
            set1.Add(20);
            Console.WriteLine("Values in Set are :");
            foreach(int i in set1)
            {
                Console.WriteLine(i);
            }

            string[] str1 = { "Ram", "Krishna", "Sita", "Ram", "Krishna" };
            //HashSet
            var newset = new HashSet<string>(str1);
            //Eliminates duplicate words
            Console.WriteLine("Elements in HashSet are:");
            string[] str2 = newset.ToArray();
            Console.WriteLine(string.Join(" ",str2));

            //SortedSet class is used to sort the elements in the set and avoid duplicates

            SortedSet<string> sortset = new SortedSet<string>();
            sortset.Add("XYZ");
            sortset.Add("BC");
            sortset.Add("MNO");
            sortset.Add("EFG");
            sortset.Add("XYZ");

            Console.WriteLine("SortedSet elements are :");
            foreach(string s in sortset)
            {
                Console.WriteLine(s);
            }
        }
    }
}
