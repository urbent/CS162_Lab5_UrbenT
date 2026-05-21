using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CustomerProductClasses;

namespace CustomerProductListTests
{
    class CustomerListTests
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 40);

            //TestCustomerListConstructor();
            //TestCustomerListAdd();
            //TestCustomerListSaveAndFill();
            //TestCustomerListRemove();
            //TestCustomerEquals();
            //TestCustomerGetHashCode();
            //TestCustomerEqualityOperator();
            //TestCustomerInequalityOperator();
            //TestCustomerListIndexer();

            Console.ReadLine();
        }

        static void TestCustomerListConstructor()
        {
            CustomerList list = new CustomerList();

            Console.WriteLine("Testing CustomerList Constructor");
            Console.WriteLine("Count.  Expecting 0. " + list.Count);
            Console.WriteLine("ToString.  Expecting empty string. " + list.ToString());
            Console.WriteLine();
        }

        static void TestCustomerListAdd()
        {
            CustomerList list = new CustomerList();
            Customer c1 = new Customer(1, "test1@example.com", "Test", "Customer", "111-111-1111");
            Customer c2 = new Customer(2, "test2@example.com",   "Test",   "Customer", "222-222-2222");

            Console.WriteLine("Testing CustomerList Add");
            Console.WriteLine("BEFORE add.  Expecting 0. " + list.Count);

            list.Add(c1);
            Console.WriteLine("AFTER Add(object).  Expecting 1. " + list.Count);
            Console.WriteLine("ToString:\n" + list.ToString());

            list += c2;
            Console.WriteLine("AFTER += operator.  Expecting 2. " + list.Count);
            Console.WriteLine("ToString:\n" + list.ToString());
            Console.WriteLine();
        }

        static void TestCustomerListSaveAndFill()
        {
            CustomerList list = new CustomerList();
            Customer c1 = new Customer(1, "test1@example.com", "Test", "Customer", "111-111-1111");
            Customer c2 = new Customer(2, "test2@example.com", "Test", "Customer", "222-222-2222");
            list.Add(c1);
            list += c2;
            list.Save();

            list = new CustomerList();
            list.Fill();
            Console.WriteLine( "Testing CustomerList Save And Fill");
            Console.WriteLine("After Fill Count.  Expecting 2. " + list.Count);
            Console.WriteLine("ToString:\n" + list.ToString());
            Console.WriteLine();
        }

        static void TestCustomerEquals()
        {
            Customer c1          = new Customer(1, "test1@example.com", "Test", "Customer", "111-111-1111");
            Customer c1Reference = c1;
            Customer c2          = new Customer(1, "test1@example.com", "Test", "Customer", "111-111-1111");

            Console.WriteLine("Testing Customer Equals");
            Console.WriteLine("Same reference.  Expecting true. " + c1.Equals(c1Reference));
            Console.WriteLine("Same attributes. Expecting true. " + c1.Equals(c2));
            Console.WriteLine();
        }

        static void TestCustomerListRemove()
        {
            CustomerList list = new CustomerList();
            Customer c1 = new Customer(1, "test1@example.com", "Test", "Customer", "111-111-1111");

            list.Fill(); 
            Console.WriteLine("Testing CustomerList Remove");
            Console.WriteLine("Before remove.  Expecting 2. " + list.Count);

            list.Remove(c1);
            Console.WriteLine("After Remove(object).  Expecting 1. " + list.Count);
            Console.WriteLine("ToString should show only test 2):\n" + list.ToString());
            Console.WriteLine();
        }

        static void TestCustomerGetHashCode()
        {
            Customer c1 = new Customer(1, "test1@example.com", "Test", "Customer", "111-111-1111");
            Customer c2 = new Customer(1, "test1@example.com", "Test", "Customer", "111-111-1111");
            Customer c3 = new Customer(3, "test3@example.com", "Test", "Customer", "333-333-3333");

            Console.WriteLine("Testing Customer GetHashCode");
            Console.WriteLine("Same attributes = same hash.  Expecting true. " + (c1.GetHashCode() == c2.GetHashCode()));
            Console.WriteLine("Diff attributes = diff hash.  Expecting false. " + (c1.GetHashCode() == c3.GetHashCode()));

            HashSet<Customer> set = new HashSet<Customer>();
            set.Add(c1);
            set.Add(c3);
            Console.WriteLine("The hash set should be able to find an object with the same attributes.  Expecting true. " + set.Contains(c2));
            Console.WriteLine();
        }

        static void TestCustomerEqualityOperator()
        {
            Customer c1 = new Customer(1, "test1@example.com", "Test", "Customer", "111-111-1111");
            Customer c1Reference = c1;
            Customer c2 = new Customer(1, "test1@example.com", "Test", "Customer", "111-111-1111");

            Console.WriteLine("Testing Customer ==");
            Console.WriteLine("Same reference.  Expecting true. " + (c1 == c1Reference));
            Console.WriteLine("Same attributes. Expecting true. " + (c1 == c2));
            Console.WriteLine();
        }

        static void TestCustomerInequalityOperator()
        {
            Customer c1 = new Customer(1, "test1@example.com", "Test", "Customer", "111-111-1111");
            Customer c2 = new Customer(1, "test1@example.com", "Test", "Customer", "111-111-1111");
            Customer c3 = new Customer(3, "test3@example.com", "Test", "Customer", "333-333-3333");

            Console.WriteLine("Testing Customer !=");
            Console.WriteLine("Same attributes. Expecting false. " + (c1 != c2));
            Console.WriteLine("Diff attributes. Expecting true. " + (c1 != c3));
            Console.WriteLine();
        }

        static void TestCustomerListIndexer()
        {
            CustomerList list = new CustomerList();
            list.Fill();

            Console.WriteLine("Testing Customer List Indexer");
            Console.WriteLine("Index 1  Expecting test 1 \n" + list[0]);
            Console.WriteLine("Index 'test2@example.com'  Expecting test2 \n" + list["test2@example.com"]);
            Console.WriteLine();
        }
    }
}
