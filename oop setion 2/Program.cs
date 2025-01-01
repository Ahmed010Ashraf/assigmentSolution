namespace oop_setion_2
{
    

    public enum weekdays
    {
        sta=1,
        sun,
        mon,
        tue,
        win,
        sar,
        fri
    }
    public enum seasons
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    public struct person
    {
        public int age;
        public string name;
    }
    [Flags]
    public enum per
    {
        delete = 1,
        read = 2,
        write = 4,
        execute = 8,
    }
    public struct points
    {
        public int x;
        public int y;
    }
    public enum colors
    {
        red ,
        green , blue ,
    }
    public class hireingData
    {
        public string day { get; set; }
        public string month{ get; set; }
        public string year { get; set; }
    }
    public enum gender
    {
        M=1,
        F
    }

    [Flags]
    public enum securityPrivileges:byte
    {
        guest=1,
        Developer=2,
        secretary=4,
        DBA =8
    }

    public class employee
    {
        public int id{ get; set; }
        public string name{ get; set; }
        public double salary{ get; set; }
        public hireingData hireingData { get; set; }
        public gender gender { get; set; }
        public securityPrivileges securityPrivileges { get; set; }

        public override string ToString()
        {
            return $"emp salary {salary}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //weekdays w;
            //foreach(weekdays day in Enum.GetValues(typeof(weekdays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //person[] arr = new person [3];
            //arr[0].name = "ali";
            //arr[0].age = 20;
            //arr[1].name = "ahmed";
            //arr[1].age = 30;
            //arr[2].name = "srour";
            //arr[2].age = 50;
            //foreach (person item in arr) {
            //    Console.WriteLine(item.name);
            //    Console.WriteLine(item.age);
            //}
            #endregion
            #region Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //bool flag = Enum.TryParse<seasons>(Console.ReadLine(), out seasons s);
            //if (flag) { 
            //switch (s)
            //    {
            //        case seasons.Spring:
            //            Console.WriteLine(" spring march to may ");
            //            break;
            //        case seasons.Summer:
            //            Console.WriteLine("  summer june to august ");
            //            break;
            //        case seasons.Winter:
            //            Console.WriteLine(" winter September to November ");
            //            break;
            //        case seasons.Autumn: 
            //            Console.WriteLine(" autumn December to February");
            //            break;

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("not found");
            //}
            #endregion
            #region Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

            //per p = per.read;
            //if ((p & per.read) == per.read) {
            //    Console.WriteLine("it is exist");
            //}
            //else
            //{
            //    p ^= per.read;
            //}
            #endregion

            #region Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //bool i = Enum.TryParse<colors>(Console.ReadLine(),out colors c);
            //if (i) {

            //        Console.WriteLine("it is a primary color");

            //}
            //else
            //{
            //    Console.WriteLine("not primarey color");
            //}
            #endregion

            #region Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //points point1;
            //points point2;
            //point1.x = int.Parse(Console.ReadLine());
            //point1.y = int.Parse(Console.ReadLine());
            //point2.x = int.Parse(Console.ReadLine());
            //point2.y = int.Parse(Console.ReadLine());

            //Console.WriteLine("the distance = ");
            //Console.WriteLine(Math.Sqrt((point1.x - point2.x ) + (point1.y - point2.y)));
            #endregion



            #region Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //person p1;
            //person p2;
            //p1.name = Console.ReadLine();
            //p1.age = int.Parse(Console.ReadLine());
            //p2.name = Console.ReadLine();
            //p2.age = int.Parse(Console.ReadLine());
            //if (p1.age > p2.age) {
            //    Console.WriteLine(p1.age);
            //    Console.WriteLine(p1.name);
            //}
            //else
            //{
            //    Console.WriteLine(p2.age);
            //    Console.WriteLine(p2.name);
            //}

            #endregion

            #region create the employee class
           // employee[] arr = new employee[3];
           // arr[0].securityPrivileges = securityPrivileges.DBA;
           // arr[0].securityPrivileges = securityPrivileges.guest;
           // arr[0].securityPrivileges = securityPrivileges.DBA ^ securityPrivileges.guest ^ securityPrivileges.Developer ^ securityPrivileges.secretary;

           ////you can also give them name and age and other props and print them 

            #endregion
        }
    }
}
