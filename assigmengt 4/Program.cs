namespace assigmengt_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 13- Write a program to allow the user to enter a string and print the REVERSE of it.
            //string x = Console.ReadLine();
            //string y = "";
            //for (int i = x.Length - 1; i>=0; i--) {
            //    y += x[i];
            //}
            //Console.WriteLine(y);
            #endregion

            #region Write a program to allow the user to enter int and print the REVERSED of it.
            //int x = int.Parse(Console.ReadLine());
            //int y = x;
            //for (int i = 0; i < x; i++)
            //{
            //    if (y == 0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.Write(y % 10);
            //        y = y / 10;
            //    }
            //}
            #endregion


            #region Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.WriteLine("enter the start point ");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the end point ");
            //int end = int.Parse(Console.ReadLine());

            //for (int i = start; i <= end; i++) {
            //    bool flag = true;
            //    if(i == 1 || i == 0)
            //    {
            //        continue;
            //    }
            //    for (int j = 2; j <= Math.Sqrt(i); j++) {
            //        if (i % j == 0 ) {
            //            flag = false;
            //            break;
            //        }
            //    }
            //    if (flag)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            #endregion


            #region  Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.WriteLine("enter the num ");
            //int x = int.Parse(Console.ReadLine());
            //string s = "";

            //if (x == 0) { Console.WriteLine("you enter zero"); }
            //while (x > 0)
            //{
            //    int rem = x % 2;
            //    s= rem + s;
            //    x /= 2;
            //}
            //Console.WriteLine(s);
            #endregion


            #region Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.WriteLine("Enter the coordinates of three points:");
            //Console.Write("Enter x1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y1: ");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter x2: ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y2: ");
            //double y2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter x3: ");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y3: ");
            //double y3 = double.Parse(Console.ReadLine());

            //if((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("lie on a single straight line");
            //}
            //else
            //{
            //    Console.WriteLine("don't lie on a single straight line");
            //}
            #endregion


            #region To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

            //int hours = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the hours");
            //if (hours >= 2 && hours < 3)
            //{
            //    Console.WriteLine("they are considered highly efficient.");
            //}
            //else if (hours >= 3 && hours < 4)
            //{
            //    Console.WriteLine("hey are instructed to increase their speed");
            //}
            //else if (hours >= 4 && hours < 5) {
            //    Console.WriteLine("they are provided with training to enhance their speed. ");
            //}
            //else
            //{
            //    Console.WriteLine("leave the company");
            //}



            ///////////////////////////another solution////////////////////////////////////
            //Console.WriteLine("enter the hours");
            //int hours = int.Parse(Console.ReadLine());
            //switch (hours) {
            //    case int h when (h >= 2 && h < 3):
            //        Console.WriteLine("they are considered highly efficient.");
            //        break;
            //    case int h when (hours >= 3 && h < 4):
            //        Console.WriteLine("hey are instructed to increase their speed");
            //        break;
            //    case int h when (h>=4 && h < 5):
            //        Console.WriteLine("they are provided with training to enhance their speed. ");
            //        break;
            //    default:
            //        Console.WriteLine("leave the company");
            //        break ;
            //}
            #endregion

        }
    }
}
