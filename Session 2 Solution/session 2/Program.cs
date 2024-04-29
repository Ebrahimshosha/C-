using System;
using System.Drawing;

namespace session_2
{
     class Program
     {
        // Entry Point
        static void Main()
        {

            // Console --> Class , WriteLine --> function in console class 
            // because in c# doesn't standalone function 
            Console.WriteLine("Hello, World!");

            #region comments
            //// naming convention
            ///*
            // * firstName  --> CamelCase     [javascript]
            // * FirstName  --> PascalCase    [C#]
            // * first-name --> KababCase     [Anglar]
            // * */
            #endregion

            #region Value Type


            // int x;
            //// allocated 4 uninitialized Bytes at Stack
            // int x = 20;
            //// int : c# keyword

            //x = 5;

            //Int32 y = 10;
            //// allocated 4 inintialized Bytes at Stack
            //// int32 : BCL

            //y = x;  // y = 5
            //x++;    // x = 6
            //Console.WriteLine(x); // 5
            //Console.WriteLine(y); // 6

            #endregion

            #region Reference Type

            //Point P1;
            //// Declare for Reference from Type "point" Refering to NULL
            //// 4    Bytes have been allocated at STACK
            //// Zero Bytes have been allocated at HEAP

            //P1 = new Point();
            ///// new
            ///// allocated required Number of Bytes for object [point] at HEAP
            ///// initialize the allocated bytes at HEAP with the default value of its Datatype = 0
            ///// call user-Defined constructor if exsists
            ///// assign reference [p1] to the allocated object

            //Point p2 = new Point();
            //p2 = P1;  // p2 had become unreachable object
            //P1.x = 5;
            //Console.WriteLine("P1.x =  " + P1.x); // 5
            //Console.WriteLine("P2.x =  " + p2.x); // 5

            #endregion

            #region Object

            //Object O1;
            //// Declare for reference from Type "Object" -- > NULL
            //// can refer to object from type "object" or object from class inheriting from "object"  

            //O1 = new Object();

            //O1 = "Ali";
            //O1 = 'A';
            //O1 = 3;
            //O1 = true;
            //O1 = new Point();

            // ---

            //Object O1 = new Object();
            //Object O2 = new Object();
            //Console.WriteLine(O1.GetHashCode()); // 54267293
            //Console.WriteLine(O2.GetHashCode()); // 18643596

            //O2 = O1;
            //// Object that O1 refered to it had become has 2 references
            //// Object that O2 refered to it had become unreachable object

            //Console.WriteLine("After O1 =O2 ");
            //Console.WriteLine(O1.GetHashCode()); // 54267293
            //Console.WriteLine(O2.GetHashCode()); // 54267293
            #endregion

            #region Fraction and Discard

            //// Fraction
            //float x   = 32.2f;
            //double y  = 2253.25;
            //decimal z = 251.399M; // or 251.399m ;

            //// Discard  --> Just for Readability
            //long Number = 100_000_000;

            #endregion

            #region Valuetype Casting

            // 1. implicit Casting [safe casting]

            //int x = 10;
            //long y = /* (long) */ x;   // implicit Casting [safe casting]
            //Console.WriteLine(y);

            // ------------------------------

            // 2. Explicit Casting [Unsafe casting]

            //long x = 10214587854;
            //checked
            //{
            //    int y = (int)x;         // Explicit Casting [Unsafe casting]

            //    unchecked 
            //    {
            //        Console.WriteLine(y);   // garbge value
            //    } 
            //}

            // ---------------------

            //int x =  9;
            //double y = /*(double)*/ x;       // implicit Casting [safe casting]

            // ---------------------

            //double x = 4.5;
            //int y = (int) x;                // Explicit Casting [Unsafe casting]

            // ---------------------

            //// 3. parse [cast from string to any Datatype]

            //Console.Write("Enter your name : ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your age : ");
            //int age = int.Parse(Console.ReadLine());

            //Console.Write("Enter your salary : ");
            //decimal salary = decimal.Parse(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("your name : " + name);
            //Console.WriteLine("your age : " + age);
            //Console.WriteLine("your salary : " + salary);

            // ---------------------

            // 4. convert [ Convert from any Datatype To any Datatype ]

            //Console.Write("Enter your name : ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your age : ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter your salary : ");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("your name : " + name);
            //Console.WriteLine("your age : " + age);
            //Console.WriteLine("your salary : " + salary);

            #endregion

        }
    }
}