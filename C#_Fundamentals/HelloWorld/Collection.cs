using System;
using System.Collections;
using System.Collections.Generic;
namespace CollectionFunction
{  
    public class Collection
    {
        //Generic collection

        List<string> strings = new List<string>();
        /*
        This is the default constructor that compiler gives you
        public Collection()
        {

        }
        */

        public void CollectionMain()
        {
            Console.WriteLine("==== Collection Demo ====");
            Console.WriteLine("List Demo");

            //Adding new elements to a collection
            strings.Add("First element");
            strings.Add("Second element");
            strings.Add("Third element");

            Console.WriteLine("For Each Demo");
            foreach (string thisIsAString in strings)
            {
                Console.WriteLine(thisIsAString);
            }
            Console.WriteLine("===For Loop Demo===");

            for (int i = 0; i < strings.Count; i +=2)
            {
                Console.WriteLine("The curent i variable holds: "+ i);
                Console.WriteLine(strings[i]);

                ArrayList nonGeneric = new ArrayList();

                nonGeneric.Add(2);
                nonGeneric.Add("This is a string");
                nonGeneric.Add(true);

                Console.WriteLine("==ArrayList Demo");

                foreach (var element in nonGeneric)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
    
}



