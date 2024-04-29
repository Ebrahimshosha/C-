using System.Text;

namespace Session_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			#region Operators

			#region Unary Operators

			//// Unary Operators → Works On One Operand (Variable)
			//int X = 10;
			//// PreFix [Increment and then Print]
			//Console.WriteLine(++X); // Print 11
			//// PostFix [Print and then Increment]
			//Console.WriteLine(X++); // Print 10

			//// PreFix [Decrement and then Print]
			//Console.WriteLine(--X); // Print 9
			//// PostFix [Print and then Decrement]
			//Console.WriteLine(X--); // Print 10 

			#endregion

			#region Binary Operators

			////Binary Operators → Works On Two Operands (Variables)
			//int Sum, Mul, Div, Sub, Mod;
			//int Num01 = 4, Num02 = 6;

			//Sum = Num01 + Num02;
			//Sub = Num02 - Num01;
			//Mul = Num01 * Num02;
			//Div = Num01 / Num02;
			//Mod = Num02 % Num01; // 6 % 4 = 2

			#endregion

			#region Assignment Operator

			//int X;

			//X = 4;

			//X += 2; // X = X + 2
			//X -= 2; // X = X - 2
			//X *= 2; // X = X * 2
			//X /= 2; // X = X / 2
			//X %= 2; // X = X % 2

			#endregion

			#region Relational Operators [Comparsion]

			//int X = 6, Y = 5;

			//Console.WriteLine(X == Y); // Equal
			//Console.WriteLine(X != Y); // Not Equal
			//Console.WriteLine(X > Y);  // More Than
			//Console.WriteLine(X >= Y); // More Than Or Equal
			//Console.WriteLine(X < Y);  // Less Than
			//Console.WriteLine(X <= Y); // Less Than Or Equal


			#endregion

			#region Logical Operators

			//Console.WriteLine(!false);
			//Console.WriteLine(false && true); // Short Circuit
			//Console.WriteLine(true || false); // Short Circuit

			////Console.WriteLine(4 < 5 && 7 < 9);

			#endregion

			#region Bitwise Operators
			// must Check-in two side

			//Console.WriteLine(false & true);  // Long Circuit 
			//Console.WriteLine(true  | false); // Long Circuit

			//Console.WriteLine(4 < 5 & 7 < 9);

			#endregion

			#region Teranry Operator [Conditional Operator]

			//int X = 10, Y = 5;

			//string Message = X > Y ? "X is More than Y" : X < Y ? "X is Less than Y": " X Equals Y";

			//Console.WriteLine(Message);

			#endregion

			#endregion

			#region Operators Priority [Precedence] and Associativity

			// Priority [Precedence]
			/*
                    1. Unary Operator (PreFix)
                    2. Round Braces ()
                    3. * / %
                    4. + -
           */

			// Associativity
			/*
             * Associativity : if you have two operators that have the same priority
             * the left operator that excute first
             */

			//int a = 20;
			//int b = 10;
			//int c = 15;
			//int d = 5;
			//int equation;


			//equation = (a + b) * c / d;     // ( 30 * 15 ) / 5

			//equation = ((a + b) * c) / d;   // (30 * 15 ) / 5

			//equation = (a + b) * (c / d);   // (30) * (15/5) 

			//equation = a + (b * c) / d;    //  20 + (150/5)  

			#endregion

			#region Block Scope

			////Block Scope
			//{
			//    int i; /// Block Scoped

			//    i = 7;
			//    i++;
			//    Console.WriteLine(i);

			//} ///end of i Scope

			#endregion

			#region String Formatting

			//// Equation: 4 + 2 = 6

			//int X = 4, Y = 2;

			//// concatication
			//string Message = "Equation: " + X + " + " + Y + " = " + (X + Y);
			//Console.WriteLine(Message);

			//// 1. Composite Formatting

			//Message = string.Format("Equation: {0} + {1} = {2}", X, Y, (X + Y));
			//Console.WriteLine(Message);

			//// 2. String Interpolation
			//// $: Manpulation Operator

			//Message = $"Equation: {X} + {Y} = {X + Y}";

			//Console.WriteLine(Message);

			#endregion

			#region Control Statements 1. Conditional Statements [if, switch]

			//Console.Write("Please Enter a Month Number at 1st Quarter: ");
			//int MonthNumber = int.Parse(Console.ReadLine());

			///if (MonthNumber == 1)
			/// Console.WriteLine("JAN");
			///else if (MonthNumber == 2)
			/// Console.WriteLine("FEB");
			///else if (MonthNumber == 3)
			/// Console.WriteLine("MAR");
			///else
			/// Console.WriteLine("The Entered Month Number is NOT Existed at 1st Quarter");


			// Jumb Table
			///switch(MonthNumber)
			///{
			///    case 1:
			///        Console.WriteLine("JAN");
			///        break;
			///    case 2:
			///        Console.WriteLine("FEB");
			///        break;
			///    case 3:
			///        Console.WriteLine("MAR");
			///        break;
			///    default:
			///        Console.WriteLine("The Entered Month Number is NOT Existed at 1st Quarter");
			///        break;
			///}

			//Console.Write("Please Enter Your Name: ");
			//string Name = Console.ReadLine();

			///if (Name == "Ahmed" || Name == "ahmed")
			/// Console.WriteLine("Hello Ahmed");
			///else if (Name == "Aya")
			/// Console.WriteLine("Hello Aya");
			///else if (Name == "Omar")
			/// Console.WriteLine("Hello Omar");
			///else if (Name == "Maryem")
			/// Console.WriteLine("Hello Maryem");
			///else if (Name == "Hadeer")
			/// Console.WriteLine("Hello Hadeer");

			//Jumb Table
			//switch (Name.ToLower())
			//{
			//    case "ahmed":
			//        Console.WriteLine("Hello Ahmed");
			//        break;
			//    case "aya":
			//        Console.WriteLine("Hello Aya");
			//        break;
			//    case "omar":
			//        Console.WriteLine("Hello Omar");
			//        break;
			//    case "maryem":
			//        Console.WriteLine("Hello Maryem");
			//        break;
			//    case "hadeer":
			//        Console.WriteLine("Hello Hadeer");
			//        break;
			//}


			//Console.Write("Please Enter Your Budget: ");
			//int Budget = int.Parse(Console.ReadLine());

			//switch (Budget)
			//{
			//    case 3000:
			//        Console.WriteLine("Option 03");
			//        goto case 2000;
			//    case 2000:
			//        Console.WriteLine("Option 02");
			//        goto case 1000;
			//    case 1000:
			//        Console.WriteLine("Option 01");
			//        break;
			//}

			// The best option to use goto : Switch case Only
			// Don't use goto somewhere outside switch

			#endregion

			#region Control Statements 2. Loop Statements

			//// 10 Statements (Steps)
			//Console.WriteLine(1);
			//Console.WriteLine(2);
			//Console.WriteLine(3);
			//Console.WriteLine(4);
			//Console.WriteLine(5);
			//Console.WriteLine(6);
			//Console.WriteLine(7);
			//Console.WriteLine(8);
			//Console.WriteLine(9);
			//Console.WriteLine(10);

			//32 Statements (Steps)
			//for (int i = 1; i <= 10; i++)
			//    Console.WriteLine(i);


			//int[] Numbers = {1, 2, 3};

			//for (int i = 0; i < 3; i++)
			//{
			//    Numbers[i] += 100;

			//    Console.WriteLine(Numbers[i]);
			//}

			//foreach (int num in Numbers)
			//{
			//    // num += 100;       // not valid
			//    Console.WriteLine(num);
			//}



			//int Number;
			//bool flag;
			//do
			//{
			//    Console.Write("Please Enter an Even Number: ");

			//    //Number = int.Parse(Console.ReadLine());  // not productive

			//    flag = int.TryParse(Console.ReadLine(), out Number);  // defensive code

			//} while (Number % 2 == 1 || !flag);

			//int Number;
			//bool flag;
			//do
			//{
			//    Console.Write("Please Enter an Even Number: ");

			//    //Number = int.Parse(Console.ReadLine());  // not productive

			//    flag = int.TryParse(Console.ReadLine(), out Number);  // defensive code

			//} while (Number % 2 == 1 || Number == 0);

			//while (database.IsConnected)
			//{

			//}


			#endregion

			#region String

			// String is a Reference Type
			// String is an Immutable [Can't Change its Value]

			//string Name;
			// Declare for Reference from type "String" → Refering to the Default Value of Reference Type => NULL
			// CLR Will Allocate 4 Bytes at STACK for the Reference
			// CLR Will Allocate Zero Bytes at HEAP


			//Name = new string("Ahmed");     /*  Name = "Ahmed"; → Syntax Sugar */
			//CLR Will Allocated 10 Bytes at HEAP
			//Name assign (refer) to allocated object "Ahmed"


			//string Name01 = "Ahmed" /*Has 2 References*/;
			//string Name02 = "Omar" /*Unreachable Object*/;


			//Console.WriteLine($"Name01 = {Name01}"); // Ahmed
			//Console.WriteLine($"Code of Name01 = {Name01.GetHashCode()}"); // 1589212332

			//Console.WriteLine($"Name02 = {Name02}"); // Omar
			//Console.WriteLine($"Code of Name02 = {Name02.GetHashCode()}"); // -404681356


			//Name02 = Name01;
			//Console.WriteLine("After Name02 = Name01;");

			//Console.WriteLine($"Name01 = {Name01}"); // Ahmed
			//Console.WriteLine($"Code of Name01 = {Name01.GetHashCode()}"); // 1589212332

			//Console.WriteLine($"Name02 = {Name02}"); // Ahmed
			//Console.WriteLine($"Code of Name02 = {Name02.GetHashCode()}"); // 1589212332



			//Name02 = "Yasmin";
			//Console.WriteLine("After Name02 = Yasmin;");

			//Console.WriteLine($"Name01 = {Name01}"); // Ahmed
			//Console.WriteLine($"Code of Name01 = {Name01.GetHashCode()}"); // 1589212332

			//Console.WriteLine($"Name02 = {Name02}"); // yasmin
			//Console.WriteLine($"Code of Name02 = {Name02.GetHashCode()}"); // -760817834


			//string Message = "Hello";

			//Console.WriteLine($"Message = {Message}"); // Hello
			//Console.WriteLine($"Message Code = {Message.GetHashCode()}"); // 1882642704



			//Message = $"{Message} Route"; Console.WriteLine("After String Change"); 
			//// new array of chars with new size = 11 Bytes

			//Console.WriteLine($"Message = {Message}"); // Hello Route
			//Console.WriteLine($"Message Code = {Message.GetHashCode()}"); // -934527732


			#endregion

			#region StringBuilder

			// StringBuilder is a Reference Type
			// StringBuilder is Mutable Type [Can Change its Value]

			//StringBuilder Message;
			//// Declare for Reference from type "StringBuilder"
			//// Refering to the default value of Reference Type = NULL
			//// CLR Will allocate 4 Bytes at STACK for the Reference
			//// CLR Will allocate 0 Bytes at Heap

			//Message = new StringBuilder("Hello");  // allocate 10 Bytes at HEAP
			//                                       // Message = "Hello"; // Not Valid - There is no syntax sugar to string builder

			//Console.WriteLine($"Message = {Message}");
			//Console.WriteLine($"Code = {Message.GetHashCode()}"); //  27252167


			//Message.Append(" Route"); Console.WriteLine("After StringBuilder Change");


			//Console.WriteLine($"Message = {Message}");
			//Console.WriteLine($"Code = {Message.GetHashCode()}"); //  27252167

			#endregion

			#region One D Array

			//// Array is a Reference type

			//int[] Numbers;
			///// Declare for Reference from type "Array of Int"
			///// Refering to the Default value of Reference Type = NULL
			///// CLR Will allocate 4 Bytes at STACK for the Reference
			///// CLR Will allocate 0 Bytes at HEAP

			//Numbers = new int[3]; // CLR will allocate 12 Bytes at HEAP,
			//                      // Initialized with the Default Value of int = 0

			//Numbers[0] = 1;
			//Numbers[1] = 2;
			//Numbers[2] = 3;
			////Numbers[3] = 4; // Exception -> OutOfRangeException

			//Console.WriteLine($"The Size of Array = {Numbers.Length}, The Number of Dimensions = {Numbers.Rank}"); // 3,1

			//for (int i = 0; i < Numbers.Length; i++)
			//    Console.WriteLine(Numbers[i]);


			#endregion

			#region Deep copy && Shallow copy

			#region array → Value Type

			//// Shallow copy
			//int[] Arr01 = { 1, 2, 3 };
			//int[] Arr02 = { 4, 5, 6 };
			//Console.WriteLine(Arr01.GetHashCode());     // 58225482
			//Console.WriteLine(Arr02.GetHashCode());     // 54267293
			//Console.WriteLine(Arr01[0]);                // 1
			//Console.WriteLine(Arr02[0]);                // 4

			//Arr02 = Arr01;
			//Console.WriteLine(Arr01.GetHashCode());     // 58225482
			//Console.WriteLine(Arr02.GetHashCode());     // 58225482
			//Console.WriteLine(Arr01[0]);                // 1
			//Console.WriteLine(Arr02[0]);                // 1
			//// Arr02 had become unreachable object

			//Arr01[0] = 10;
			//Console.WriteLine(Arr01[0]);  // 10
			//Console.WriteLine(Arr02[0]);  // 10

			//// Deep copy
			//int[] Arr01 = { 1, 2, 3 };
			//int[] Arr02 = { 4, 5, 6 };
			//Console.WriteLine(Arr01.GetHashCode());     // 32854180
			//Console.WriteLine(Arr02.GetHashCode());     // 27252167
			//Console.WriteLine(Arr01[0]);                // 1
			//Console.WriteLine(Arr02[0]);                // 4

			//Console.WriteLine("==== After Clone =======");

			////Arr02 = Arr01.Clone();  // Invalid because clone() return object so you must do explicit Casting to return array of integer
			//Arr02 = (int[])Arr01.Clone();   // CLR create a new object at heap
			//// Arr02 had become Reference to new object not Arr01 object
			//// Clone() Method: Will Generate New Object With New And Diffrent Identity,
			//// but with The Same Object State[Data] of Calller Object "Arr01"
			//Console.WriteLine(Arr01.GetHashCode());     // 32854180
			//Console.WriteLine(Arr02.GetHashCode());     // 43942917
			//Console.WriteLine(Arr01[0]);                // 1
			//Console.WriteLine(Arr02[0]);                // 1 but in another object

			//Arr01[0] = 10;
			//Console.WriteLine(Arr01[0]);  // 10
			//Console.WriteLine(Arr02[0]);  // 1 

			#endregion

			#region array → Reference Type

			//StringBuilder[] Names1 = new StringBuilder[1];
			//Names1[0] = new StringBuilder("omar");

			//StringBuilder[] Names2 = new StringBuilder[1];

			//Console.WriteLine(Names1.GetHashCode()); // 54267293
			//Console.WriteLine(Names2.GetHashCode()); // 18643596

			//Names2 = Names1;

			//Console.WriteLine(Names1.GetHashCode()); // 54267293
			//Console.WriteLine(Names2.GetHashCode()); // 54267293

			//Console.WriteLine(Names1[0]); // omar
			//Console.WriteLine(Names2[0]); // omar

			//Names2[0].Append("Ahmed");

			//Console.WriteLine(Names1[0]); // omar Ahmed
			//Console.WriteLine(Names2[0]); // omar Ahmed

			// Deep Copy
			//StringBuilder[] Names1 = new StringBuilder[1];
			//Names1[0] = new StringBuilder("omar");

			//StringBuilder[] Names2 = new StringBuilder[1];

			//Console.WriteLine(Names1.GetHashCode()); // 54267293
			//Console.WriteLine(Names2.GetHashCode()); // 18643596

			//Names2 = (StringBuilder[])Names1.Clone();

			//Console.WriteLine(Names1.GetHashCode()); // 54267293
			//Console.WriteLine(Names2.GetHashCode()); // 33574638

			//Console.WriteLine(Names1[0]); // omar
			//Console.WriteLine(Names2[0]); // omar

			//Names2[0].Append("Ahmed");

			//Console.WriteLine(Names1[0]); // omar Ahmed
			//Console.WriteLine(Names2[0]); // omar Ahmed

			#endregion

			#endregion

			#region Two D Array - Rectangular Array

			//int[,] Marks = new int[3, 5];

			//Console.WriteLine($"The Size of Array = {Marks.Length}, The Number of Dimensions = {Marks.Rank}"); // 15,2

			//Console.WriteLine(Marks.GetLength(0)); // 3
			//Console.WriteLine(Marks.GetLength(1)); // 5
			//Console.WriteLine(Marks.Length); // 15


			//bool Flag;
			//for (int i = 0; i < Marks.GetLength(0); i++)
			//{
			//    Console.WriteLine($"Please Enter The Marks of Student Number: {i + 1}");


			//    for (int j = 0; j < Marks.GetLength(1); /* j++ */)
			//    {
			//        Console.Write($"Please Enter The Marks of Subject Number ({j + 1}) : ");

			//        //Marks[i, j] = int.Parse(Console.ReadLine());
			//        Flag = int.TryParse(Console.ReadLine(), out Marks[i, j]);

			//        //if (Flag && Marks[i, j] >= 0)
			//        //    j++;
			//        j = Flag && Marks[i, j] >= 0 ? ++j : j;
			//    }

			//    Console.WriteLine("====================");
			//}

			//Console.Clear();
			//for (int i = 0; i < Marks.GetLength(0); i++)
			//{
			//    Console.WriteLine($"The Marks of Student Number: {i + 1}");

			//    for (int j = 0; j < Marks.GetLength(1); j++)
			//    {
			//        Console.WriteLine($"The Marks of Subject Number ({j + 1})  = {Marks[i, j]} ");
			//    }

			//    Console.WriteLine(" ------------------------------ ");
			//} // Time Complexity = N ^ 2

			//// Iterate On 2D Array using One Loop
			//for (int i = 0; i < Marks.Length /* 15 */; i++)
			//{
			//    Console.WriteLine(Marks[i / Marks.GetLength(1), i % Marks.GetLength(1)]);
			//} // Time Complexity = N 

			#endregion

			#region Two D Array - Judged Array

			//// Judged Array is -> One D Array for Addresses of other Arrays with different sizes

			//int[][] Numbers = new int[3][];

			//Numbers[0] = new int[3] { 9, 1, 7 };
			//Numbers[1] = new int[2] { 5, 3 };
			//Numbers[2] = new int[1] { 7 };

			//Console.WriteLine(Numbers.Length); // 3

			//for (int i = 0; i < Numbers.Length; i++)
			//{
			//    for (int j = 0; j < Numbers[i].Length; j++)
			//    {
			//        Console.WriteLine(Numbers[i][j]);
			//    }
			//}

			#endregion

			#region Array Methods

			//int[] Numbers = { 9, 3, 10, 2, 8, 10, 6, 5, 1 };

			//int[] Arr01 = { 1, 2, 3 };
			//int[] Arr02 = new int[5];   /*  0 , 0, 0, 0, 0  */

			#region 1. Class Member Methods [Static Methods]

			//Array.Sort(Numbers);
			//for (int i = 0; i < Numbers.Length; i++)
			//{
			//    Console.Write(Numbers[i] + " ");
			//}
			//Console.WriteLine();

			//Array.Copy(Arr01, Arr02, 2);
			//for (int i = 0; i < Arr01.Length; i++)
			//{
			//    Console.Write(Arr01[i] + " ");
			//}
			//Console.WriteLine();

			//for (int i = 0; i < Arr02.Length; i++)
			//{
			//    Console.Write(Arr02[i] + " ");
			//}
			//Console.WriteLine();

			//Array.Clear(Numbers);
			//for (int i = 0; i < Numbers.Length; i++)
			//{
			//    Console.Write(Numbers[i] + " " );
			//}
			//Console.WriteLine();

			//Array.ConstrainedCopy(Arr01, 1, Arr02, 0, 2);
			//for (int i = 0; i < Arr01.Length; i++)
			//{
			//    Console.Write(Arr01[i] + " " );                
			//}
			//Console.WriteLine();

			//for (int i = 0; i < Arr02.Length; i++)
			//{
			//    Console.Write(Arr02[i] + " ");

			//}

			//Arr02 = (int[])Array.CreateInstance(typeof(int), 10); // new int[10]

			//int[,] Arr03 = (int[,]) Array.CreateInstance(typeof(int), 2 , 3);

			//int[,,] Arr03 = (int[,,]) Array.CreateInstance(typeof(int), 2, 4, 3);

			//int index = Array.IndexOf(Numbers, 10); // 2

			//int index = Array.LastIndexOf(Numbers, 10); // 5

			//Console.WriteLine(index);


			//foreach (int number in Arr02)
			//    Console.WriteLine(number);

			#endregion

			#region 2. Object Member Methods [Non-Static Methods]

			//Arr01.CopyTo(Arr02, 1);  // 0, 1, 2, 3, 0

			////Arr01.GetLength(0);
			//Arr01.GetValue(1); // Arr01[1]
			//Arr01.SetValue(100, 1); // Arr01[1] = 100


			//foreach (int number in Arr02)
			//    Console.WriteLine(number);

			#endregion

			#endregion

			#region Boxing, UnBoxing

			//// Boxing   : Casting from ValueType to ReferenceType
			//// UnBoxing : Casting from ReferenceType to ValueType

			//object O1;  O1 → ReferenceType

			//O1 = new object();

			//O1 = true;             // bool       Casting from [ValueType] to object[ReferenceType] → Boxing
			//O1 = 5;                // int        Casting from [ValueType] to object[ReferenceType] → Boxing
			//O1 = 'A';              // char       Casting from [ValueType] to object[ReferenceType] → Boxing
			//O1 = 3.3;              // double     Casting from [ValueType] to object[ReferenceType] → Boxing
			//O1 = new DateTime();   // DateTime   Casting from [ValueType] to object[ReferenceType] → Boxing
			//O1 = new DateOnly();   // DateOnly   Casting from [ValueType] to object[ReferenceType] → Boxing
			//O1 = new TimeOnly();   // TimeOnly   Casting from [ValueType] to object[ReferenceType] → Boxing

			// O1 Reference had become refer to ValueType


			//int X = 5;

			//object O1 = /*(object)*/ X;
			//// Casting from int[ValueType] to object[ReferenceType] Implicity
			//// Parent = ChildX
			//// Animal = Dog
			//// Safe Casting
			//// Boxing

			//object O1 = 5;
			////O1 = "Hamda";

			//int X = (int) O1; // May Throw Exception [InvalidCastingException]
			//// Casting from object[ReferenceType] to int[ValueType] Explicitly
			//// ChildX = (ChildX) Parent
			//// Dog = (Dog) Animal
			//// Unsafe Casting
			//// UnBoxing

			#endregion

			#region Nullable Types

			// NullableTypes : ValueTypes allows NULL as a Value
			// Assign Null as a Value for ValueType[int, char, bool, decimal, etc] Variables

			//int Age = 22; // Integer
			//Age = null; Invalid

			//int? X; // Nullable Integer: Allow int Value + Null

			//X = 10;
			//X = null;  // valid
			//Console.WriteLine(X);

			////double? Y; // Nullable Double: Allow double Value + Null
			////Y = 3.3;
			////Y = null;

			//int X = 8;
			//// X: allow int values only

			//int? Y = /*(int?)*/ X;
			//// Y: allow int values + null
			//// Safe Casting, Implicit Casting


			//int? K = 4;
			//K = null;

			//int M;

			// K: allow int values + null
			// M: allow int values only
			//M = (int) K;
			// Unsafe Casting Explicit Casting

			//if (K is not null)
			//    M = (int) K;
			//else
			//    M = 0;

			//if (K.HasValue)
			//    M = K.Value;
			//else
			//    M = 0;

			//M = K.HasValue ? K.Value : 0;

			//// null-coalescing operator : ??

			//M = K ?? 0; // Syntax Sugar  --> M = K.HasValue ? K.Value : 0;

			#endregion

			#region Null Propagation Operator

			//double Num = default; // 0

			//int[] Arr = default; // null

			//for (int i = 0; (Arr != null) && i < Arr.Length; i++)
			//    Console.WriteLine(i);


			//if (Arr != null)
			//{
			//    for (int i = 0; i < Arr.Length; i++)
			//        Console.WriteLine(i);
			//}

			/// Null Propagation Operator (Null Conditional Operator)
			//for (int i = 0; i < Arr?.Length; i++)
			//    Console.WriteLine(Arr[i]);

			//// Arr?.Length ==> Syntax Sugar ==> Arr != null? Arr.Length: null


			// int Length = Arr.Length;  // Unsafe (Exception), Maybe Arr is null
			// int Length = Arr?.Length; // Unsafe (Exception), Maybe Arr is null

			// Answer :

			// 1
			// int? Length = Arr?.Length; // Safe  //Nullable Type

			// 2
			// int Length = Arr?.Length ?? 0;     // Null-coalescing operator

			#endregion

		}
	}
}