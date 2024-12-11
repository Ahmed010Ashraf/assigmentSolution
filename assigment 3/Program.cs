namespace assigment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1)Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.WriteLine("enter a number");
            //int.TryParse(Console.ReadLine(), out var result);
            //if (result % 4 == 0 && result % 3 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            #endregion


            #region q2) Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("enter a number");
            //int.TryParse(Console.ReadLine(), out var result);
            //if (result > 0)
            //{
            //    Console.WriteLine("positive");
            //}
            //else if(result < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("zero");
            //}
            #endregion

            #region q3) Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.WriteLine("enter a number 1");
            //int.TryParse(Console.ReadLine(), out var result1);
            //Console.WriteLine("enter a number 2");
            //int.TryParse(Console.ReadLine(), out var result2);

            //Console.WriteLine("enter a number 3");
            //int.TryParse(Console.ReadLine(), out var result3);


            //if (result1 > result2 && result1 > result3)
            //{
            //    Console.WriteLine($"the max is : {result1}");
            //    if (result2 > result3)
            //    {
            //        Console.WriteLine($"the min is : {result3}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"the min is : {result2}");
            //    }
            //}
            //else if (result2 > result1 && result2 > result3) {
            //    Console.WriteLine($"the max is : {result2}");
            //    if (result1 > result3)
            //    {
            //        Console.WriteLine($"the min is : {result3}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"the min is : {result1}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"the max is : {result3}");
            //    if (result1 > result2) {
            //        Console.WriteLine($"the min is : {result2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"the min is : {result1}");
            //    }
            //}

            #endregion


            #region q4) Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("enter a number ");
            //int.TryParse(Console.ReadLine(), out var result);

            //if (result % 2 == 0) {
            //    Console.WriteLine("even");
            //}
            //else
            //{
            //    Console.WriteLine("odd");
            //}
            #endregion


            #region q5) Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.WriteLine("enter a cha : ");
            //char.TryParse(Console.ReadLine(), out char c);
            //string s = "aeiou";

            //if (s.Contains(c) || s.ToUpper().Contains(c))
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}
            #endregion


            #region q6)Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("enter a num : ");
            //int.TryParse(Console.ReadLine(), out int result);
            //for (int i = 1; i <= result; i++) {
            //    Console.WriteLine(i);
            //}
            #endregion

            #region q7)Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.WriteLine("enter a num : ");
            //int.TryParse(Console.ReadLine(), out int result);
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i * result);
            //}
            #endregion

            #region q8)Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("enter a num : ");
            //int.TryParse(Console.ReadLine(), out int result);
            //for (int i = 1; i <= result; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region q9)Write a program that takes two integers then prints the power.
            //Console.WriteLine("enter a base : ");
            //int.TryParse(Console.ReadLine(), out int basee);
            //Console.WriteLine("enter a exp : ");
            //int.TryParse(Console.ReadLine(), out int exp);
            //int result = 1;
            //for (int i = 0; i < exp; i++) {
            //    result *= basee;
            //}
            //Console.WriteLine(result);
            #endregion

            #region  q10)Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int result = 0;
            //for (int i = 0; i < 5; i++) {
            //    Console.WriteLine($"enter the number {i+1} : ");
            //    int.TryParse(Console.ReadLine(), out int num);
            //    result += num;
            //}
            //Console.WriteLine($"the total is : {result}");
            //Console.WriteLine($"the avarage is : {result/5}");
            //Console.WriteLine($"the percentage is : {(result / (double)500)*100}");

            #endregion


            #region q11)Write a program to input the month number and print the number of days in that month.
            //Console.WriteLine("enter a month number : ");
            //int.TryParse(Console.ReadLine(), out int num);

            //if (num == 1 || num == 3 || num == 5 || num == 6 || num == 7 || num == 10 || num == 12) {
            //    Console.WriteLine("31 day");
            //}
            //else if(num == 2)
            //{
            //    Console.WriteLine("28 day");
            //}
            //else
            //{
            //    Console.WriteLine("30 day");
            //}
            #endregion


            #region 12) Write a program to create a Simple Calculator.
            //Console.WriteLine("enter a first number : ");
            //int.TryParse(Console.ReadLine(), out int num1);
            //Console.WriteLine("enter a last number : ");
            //int.TryParse(Console.ReadLine(), out int num2);
            //Console.WriteLine("enter a operator number : ");
            //char.TryParse(Console.ReadLine(), out char oper);
            //switch (oper)
            //{
            //    case '+': Console.WriteLine(num1+num2);break;
            //    case '-': Console.WriteLine(num1 - num2); break;
            //    case '*': Console.WriteLine(num1 * num2); break;
            //    case '/': Console.WriteLine(num1 / num2); break;
            //        default : Console.WriteLine(num1% num2); break;
            //}
            #endregion
        }
    }
}
