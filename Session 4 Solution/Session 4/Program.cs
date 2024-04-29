namespace Session_4
{

    // what do U can write in namespace ?

    // 1. Class
    // 2. Struct
    // 3. Interface
    // 4. Enum

    internal class Program
    {
        /// what do U can write in Class?
        /// 1. function (Method) 
        /// 2. Data (Attribute)

        #region Functio ProtoType and Calling
        static void PrintShape1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("'__'");
            }
        }

        static void PrintShape2(int count = 10, string parametr = "$_$")
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(parametr);
            }
        }
        #endregion

        #region Value Type parameters

        public static void SWAP1(int X, int Y)         /* Pass By Value */
        {
            int Temp = X;
            X = Y;
            Y = X;
        }

        public static void SWAP2(ref int X, ref int Y)   /* Pass By Reference */
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }

        #endregion

        #region Reference Type parameters With same result

        #region Passing By Value

        static int SumArray1(int[] Arr) /* Arr assign to the same address of Numbers */
        {
            int sum = 0;

            if (Arr != null)  // To check Arr is null or not
            {
                Arr[0] = 100;
                for (int i = 0; i < Arr.Length; i++)
                {
                    sum += Arr[i];
                }
            }
            return sum;
        }

        #endregion

        #region Passing By Refrence

        static int SumArray2(ref int[] Arr)
        {
            int sum = 0;

            if (Arr != null)  // To check Arr is null or not
            {
                Arr[0] = 100;
                for (int i = 0; i < Arr.Length; i++)
                {
                    sum += Arr[i];
                }
            }
            return sum;
        }

        #endregion

        #endregion

        #region Reference Type With diffrent result

        #region Passing By Value

        //static int SumArray3(int[] Arr) /* Arr assign to(هيشاور) the same address of Numbers */
        //{
        //    int sum = 0;

        //    if (Arr != null)  // To check Arr is null or not
        //    {

        //        Arr = new int[] { 4, 5, 6 }; // Arr assign to new address in heap
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            sum += Arr[i];
        //        }
        //    }

        //    return sum; //15
        //}
        #endregion

        #region Passing By Refrence

        //static int SumArray4(ref int[] Arr)
        //{
        //    int sum = 0;

        //    if (Arr != null)  // To check Arr is null or not
        //    {
        //        Arr = new int[] { 4, 5, 6 };
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            sum += Arr[i];
        //        }
        //    }
        //    return sum;
        //}

        #endregion

        #endregion

        #region OutPut Parameters

        #region Passing by value

        public static void SumMul(int X, int Y)
        {
            int Mul = X * Y;
            int Sum = X + Y;
        }

        #endregion

        #region Passing by out

        public static void SumMul(int X, int Y, out int Sum, out int Mul) 
        {
            Mul = X * Y;
            Sum = X + Y;
        }

        #endregion

        #region Passing by Reference

        //public static void SumMul(int X, int Y, out int Sum, out int Mul) // output params (Sum,Mul)  Must be initialized Inside body Function
        //{
        //    Mul = X * Y;
        //    Sum = X + Y;
        //}

        #endregion

        #endregion

        #region Params

        public static int SumArr(params int[] Arr)  // params must be the last parameter in function
        {
            int Sum = 0;
            for (int i = 0; i < Arr.Length; i++)
                Sum += Arr[i];
            return Sum;
        }

        #endregion

        #region Exceptions Handling

        static void DoSomeCode()
        {
            int X, Y, Z;

            try
            {
                Console.Write("Please Enter the First Number: ");
                X = int.Parse(Console.ReadLine());

                Console.Write("Please Enter the Second Number: ");
                Y = int.Parse(Console.ReadLine());

                Z = X / Y;

                int[] Arr = new int[3] { 1, 2, 3 };

                Arr[10] = 99;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("ay 7aga");
        }

        static void DoSomeProtectiveCode()
        {
            int X, Y, Z;



            do
            {
                Console.Write("Please Enter the First Number: ");
            } while (!int.TryParse(Console.ReadLine(), out X));

            do
            {
                Console.Write("Please Enter the Second Number: ");
            } while (!int.TryParse(Console.ReadLine(), out Y) || Y == 0);


            Z = X / Y;

            int[] Arr = new int[3] { 1, 2, 3 };

            if (Arr.Length > 10)
                Arr[10] = 99;
        }

        #endregion

        // main method : Entry Point
        static void Main(string[] args)
        {

            #region Functio ProtoType and Calling

            //PrintShape1();  /* → Program.PrintShape(); */
            // As main functoin and PrintShape function at the same class (Program)
            // It doesn't matter if you don't write the class name (program)

            //PrintShape2(10, "'&'");  // Passing Parameters using Order (Position)
            //PrintShape2(count : 10,parametr : "'&'");  // Passing Parameters using Name

            //Notations
            //Console.WriteLine("Hey \nIbrahim Shosha");
            //Console.WriteLine("Hey \tIbrahim Shosha");

            // escaping
            //Console.WriteLine( "Hey \\Ibrahim \\ Shosha ");
            //Console.WriteLine(@"Hey \Ibrahim \ Shosha ");

            //string FilePath = "E:\\Route\\Back-end\\2 C # Basics\\main\\Session 4\\videos";
            //string FilePath2 = @"E:\Route\Back-end\2 C # Basics\main\Session 4\videos";
            //Console.WriteLine(FilePath,FilePath2);

            //PrintShape2(2, "/*\\");
            //PrintShape2(2, @"/*\");

            #endregion

            #region Value Type

            // Passing By Value
            //int Num01 = 9, Num02 = 4;
            //Console.WriteLine($"Num01 = {Num01}, Num02 = {Num02}");
            //SWAP1(Num01, Num02);        // Passing By Value
            //Console.WriteLine("swapping");
            //Console.WriteLine($"Num01 = {Num01}, Num02 = {Num02}");

            //// Passing By Reference
            //int Num03 = 9, Num04 = 4;
            //Console.WriteLine($"Num03 = {Num03}, Num04 = {Num04}");
            //SWAP2(ref Num03, ref Num04); // Passing By Reference 
            //Console.WriteLine($"Num03 = {Num03}, Num04 = {Num04}");


            #endregion

            #region Reference Type With same result

            #region Passing By Value
            //int[] Numbers = { 1, 2, 3 };
            //int Total = SumArray1(Numbers);  // passing by value
            //                                 // SumArray(CopyOfAddress(Numbers))
            //Console.WriteLine($"Sum of Array = {Total}");
            //Console.WriteLine(Numbers[0]);
            #endregion

            #region Passing By Refrence

            //int[] Numbers = { 1, 2, 3 };
            //int Total = SumArray2(ref Numbers);  // passing by Ref
            //                                     // SumArray(Address(Numbers) itself)
            //Console.WriteLine($"Sum of Array = {Total}");
            //Console.WriteLine(Numbers[0]);

            #endregion

            #endregion

            #region Reference Type With diffrent result

            #region Passing By Value
            //int[] Numbers = { 1, 2, 3 };
            //int Total = SumArray3(Numbers);  // passing by value
            //                                 // SumArray(CopyOfAddress(Numbers))
            //Console.WriteLine($"Sum of Array = {Total}"); // 15
            //Console.WriteLine(Numbers[0]); // 1
            #endregion

            #region Passing By Refrence

            //int[] Numbers = { 1, 2, 3 };
            //int Total = SumArray4(ref Numbers);  // passing by Ref
            //                                     // SumArray(Address(Numbers) itself)
            //Console.WriteLine($"Sum of Array = {Total}"); //15
            //Console.WriteLine(Numbers[0]); // 4

            #endregion

            #endregion

            #region OutPut Parameters

            #region Passing by value

            //int A = 5, B = 10;
            //SumMul(A, B); // Passing by value  → Read Only

            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            #endregion

            #region Passing by out

            //int A = 5, B = 10;
            ////int SResult, MResult;
            //SumMul(A, B, out int SResult, out int MResult); // Passing by out (Only output)
            ////SumMul(A, B, out _, out MResult); // if you don't SResult return value 
            //Console.WriteLine($"Sum = {SResult}");
            //Console.WriteLine($"Mul = {MResult}");

            // /*  Write at First and Then Read  */

            #endregion

            #region Passing by ref

            //int A = 5, B = 10;
            //int SResult = 0, MResult = 0;            // outputs must be intialized befor passing by reference
            //SumMul(A, B, ref SResult, ref MResult);  // passing by Reference (Input Output params)
            //Console.WriteLine($"Sum = {SResult}");
            //Console.WriteLine($"Mul = {MResult}"); 

            // /* Read at First and Then Write  */

            #endregion

            #endregion

            #region Params

            ////int SumResult = SumArr(new int[] { 1, 2, 3, 4, 5, 6 });
            //int SumResult = SumArr(1, 2, 3, 4, 5, 6);
            //Console.WriteLine(SumResult);

            #endregion

            #region Exceptions Handling

            //DoSomeCode();

            //try
            //{
            //    DoSomeProtectiveCode();

            //    //throw new Exception();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    // [Release | Deallocate | Delete | Close] UnMananged Resources (DatabaseConnection, File)
            //    // Mananged Resources → C # is Mananged Code controlled by CLR
            //    // but (DatabaseConnection, File) UnMananged Resources Not controlled by CLR
            //    // So if U want connect DataBase Do it in Try{} and close it in finally{}
            //    // finally {} → Must excute Whether there is an exception or not
            //    Console.WriteLine("Finally");
            //}


            /* Exception
            ////// 1. SystemException
            //////////////// 1. FormatException
            //////////////// 2. IndexOutOfRangeException
            //////////////// 4. NullReferenceException
            //////////////// 4. InvalidOperationException
            //////////////// 5. ArithmeticException
            ///////////////////////// 5.1 DivideByZeroException
            ///////////////////////// 5.2 OverflowException
            ////// 2. ApplicationException
            */

            #endregion
        }
    }
}