using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<List<object>> list = new List<List<object>>();
            //List<Object> list1 = new List<object>();
            //list1.Add(101);
            //list1.Add(102);
            //list1.Add(103);

            //List<Object> list2 = new List<object>();
            //list2.Add("Test1");
            //list2.Add("Test2");
            //list2.Add("Test3");

            //list.Add(list1);
            //list.Add(list2);

            //foreach (List<object> obj in list)
            //{
            //    foreach (object obj1 in obj)
            //    {
            //        Console.WriteLine(obj1);
            //    }
            //    Console.WriteLine();
            //}

            //corporateCustomer cc = new corporateCustomer();
            //Console.WriteLine(cc.ID);
            //savingCustomer sc = new savingCustomer();
            //Console.WriteLine(sc.ID);
        }
    }

    public abstract class Customer
    {
        public Customer()
        {
            Print();
        }


        public abstract void Print();
        //public Customer()
        //{
        //    this._id = Guid.NewGuid();
        //}
        //private Guid _id;
        //public Guid ID
        //{
        //    get
        //    {
        //        return this._id;
        //    }
        //}
    }


    public class corporateCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Corporate Method Invoked");
            //throw new NotImplementedException();
        }
    }

    public class savingCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Saving method invoked");
            //throw new NotImplementedException();
        }
    }
}
