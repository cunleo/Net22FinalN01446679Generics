using System;
using System.Collections.Generic;

namespace Net22FinalN01446679Generics
{
    /*
     * Write a generic class that meets the following requirements:
1)    That constrains a developer to only instantiate the class based on value types
2)    Contains a private generic collection
3)    Has a method to add items to the private collection
4)    Has a method that will return an  item from the list (e.g. item 3 or item 4 in the list)
5)    Has a method that returns a sorted collection with the items in descending order
    */
    class Program
    {
        static void Main(string[] args)
        {
            List<int> MyList = new List<int>();
            var MyListClass = new ClassCrud<int>(MyList);
            MyListClass.add(1);
            MyListClass.add(12);
            MyListClass.add(5);

            Console.WriteLine("{0} was returned", MyListClass.getItem(2)) ;
            //Console.WriteLine(MyListClass.sortCollection());

            Console.ReadLine();
           
           

        }
    }

    public class ClassCrud<T> where T:struct
    {
        private List<T> _myList;
        public ClassCrud(List<T> MyList)
        {
            _myList = MyList;
        }
        public List<T> MyList { get; set; }
        public void add(T item)
        {
            _myList.Add(item);
        }

        public T getItem(int itemindex)
        {
           return  _myList[itemindex];
        }


        //public List<T> sortCollection()
        //{
        //   // return  TheList.Reverse();
        //}

    }

}
