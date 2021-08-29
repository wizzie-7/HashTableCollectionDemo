using System;
using System.Collections;

namespace HashTableCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable HT = new Hashtable();
            //HT.Add(1, "VIVEK");
            //HT.Add(2, "KRUNAL");
            //HT.Add(3, "NIRBHAY");
            //HT.Add(4, "ABHI");


            HashTableDirectory HTD = new HashTableDirectory();
            HTD.HashTableMethod();

            //Console.WriteLine("Key and Values :");
            //HTD.printKeyValue(HT);
            
        }
    }
    public class HashTableDirectory
    {
       public void HashTableMethod()
        { 
            Hashtable HT = new Hashtable();
            HT.Add(1, "VIVEK");
            //HT.Add(1, "XYZ");
            HT.Add(2, "KRUNAL");
            HT.Add(3, "NIRBHAY");
            HT.Add(4, "ABHI");

            Console.WriteLine("Key and Values :");
            printKeyValue(HT);

        }
        public void printKeyValue(Hashtable ht)
        {
            IDictionaryEnumerator INT = ht.GetEnumerator();
            //IComparable IC = ht.GetEnumerator();
            while (INT.MoveNext())
            {
                Console.Write("\t{0}:\t{1}", INT.Key, INT.Value);
            }
            //INT.2 = IC.CompareTo(INT.3);
        }
    }
}
