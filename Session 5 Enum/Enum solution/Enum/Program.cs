namespace Enum
{
    internal class Program
    {
        enum Grades
        {
            A, B, C, D, E, F
        }
        enum Gender
        {
            Male = 1, M = 1, Female = 2, F = 2
        }
        enum Branches : byte
        {
            SmartVillage = 105, Dokki = 201, NasrCity = 223, Alex, Mansoura, BNS
        }

        [Flags] // Attributes // Data Annotation 
        enum Permissions : byte
        {
            Delete = 1, Execute = 2, Write = 4, Read = 8
        }

        class Employee
        {
            public int Id { set; get; }
            public string Name { set; get; }
            public decimal Salary { set; get; }
            public Permissions permissions { set; get; }
            

        }
        static void Main(string[] args)
        {
            #region Enum Ex01

            //Grades G = Grades.A;
            //if (G == Grades.A)
            //    Console.WriteLine(":)");

            //G = (Grades)2; //C
            //Console.WriteLine(G);

            //Grades G = (Grades)8; // 8
            //Console.WriteLine(G);

            //Branches B = Branches.Dokki;
            //Console.WriteLine(B); //  Dokki

            //int V = (int)Branches.Dokki;
            //Console.WriteLine(V); //  201

            //Branches S = (Branches)201;
            //Console.WriteLine(S);  //  Dokki

            #endregion

            #region Enum Ex02
            //Employee emp = new Employee();
            //emp.Id = 1;
            //emp.Name = "Test";
            //emp.permissions = (Permissions)7;

            //Console.WriteLine(emp.permissions);

            //Console.Write("1  ");
            //Permissions MyP = Permissions.Read;
            //Console.WriteLine(MyP);  // Read

            //Console.Write("2  ");
            //MyP = (Permissions)3;
            //Console.WriteLine(MyP);  // Delete, Execute

            //Console.Write("3  ");
            //MyP = (Permissions)7;
            //Console.WriteLine(MyP);  // Delete, Execute, Write


            //////// If You Want To Add Permission, Do OR Bitwise Operation
            //Console.Write("4  ");
            //MyP |= Permissions.Read; // MyP = MyP |  Permissions.Read;  
            //                         // (0111)7 | (1000)8 → (1111)15
            //Console.WriteLine(MyP);  // Delete, Execute, Write, Read 

            ////// If You Want To Remove (Deny) Permission, Do NAND Bitwise Operation
            //Console.Write("5  ");
            //MyP &= (~Permissions.Read); // MyP = MyP & (~Permissions.Read)
            //                            //      (1111)15 & (~1000)8 
            //                            //      (1111)15 & (0111)8 → (0111)7
            //Console.WriteLine(MyP);     // Delete, Execute, Write


            //// If You Want To Toggle Permission, Do XOR Operation 
            //// if the Permission exsists , XOR will Remove it 
            //// if the Permission not exsists , XOR will Add it 

            //// in this case removed Execute
            //Console.Write("6  ");
            //MyP ^= Permissions.Execute; // MyP = MyP ^ Permissions.Execute
            //                            //  (0111)7 ^ (0010)2 → (0101)5
            //Console.WriteLine(MyP);     //  Delete, Write

            //// in this case Add Execute
            //Console.Write("7  ");
            //MyP ^= Permissions.Execute; //  MyP = MyP ^ Permissions.Execute
            //                            //  (0101)5 ^ (0010)2 → (0111)7
            //Console.WriteLine(MyP);     //  Delete, Execute, Write

            //// Check Read Permission is existed inside MyP, Do AND operation
            //if ((MyP & Permissions.Read) == Permissions.Read)
            //    Console.WriteLine("Read Existed");
            //else
            //    Console.WriteLine("Read Not Existed");

            #endregion

        }
    }
}