namespace assigment_5
{
    internal class Program
    {
        #region swap by value and by referance 
        static void swapbyvalue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void swapbyref(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        #endregion

        #region print the sum of the digit
        static int print_th_sum_digits(int num)
        {
            int sum = 0;
            while (num !=0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        #endregion

        #region is prime
        static bool isprime(int num) {
            for (int i = 2; i < Math.Sqrt(num); i++) {
                if(num == 0 || num==1) return false;
                if(num % i == 0)
                {
                    return false;
                }
            
            }
            return true;
        }
        #endregion

        #region factorial

        static int fact(int num) {
            int sum = 1;
            for (int i = 1; i <= num; i++) {
                sum *= i;
            }
            return sum;
        }
        #endregion


        #region replace char form string 
        static string changechar(string s , char x , int pos) {
            char[] arr = s.ToCharArray();
            arr[pos] = x;
            return new string(arr);
        }
        #endregion
        static void Main(string[] args)
        {
            #region Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.WriteLine("enter the size ");
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 0; i < x; i++) {
            //    for (int j = 0; j < x; j++) {
            //        if (i == j) {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region Write a program in C# Sharp to find the sum of all elements of the array.
            //int[]arr = new int[] { 1, 2,3 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++) { 
            //sum += arr[i];
            //}
            //Console.WriteLine(sum);
            #endregion



            #region Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] arr = { 1, 2, 3 };
            //int [] arr2 = { 4,5,6};
            //int [] arr3 = new int[arr.Length + arr2.Length];
            //Array.Copy(arr , 0 , arr3 , 0 , arr.Length);
            //Array.Copy(arr2 , 0 , arr3 , arr.Length, arr2.Length);
            //Array.Sort(arr3);
            //Console.WriteLine(String.Join("," , arr3));
            #endregion


            #region  Write a program in C# Sharp to count the frequency of each element of an array
            //int[]arr = new int [] { 1, 2,3,2,1,4,5 };
            //int[] freq = new int[100];
            //for (int i = 0; i < arr.Length; i++) {
            //    freq[arr[i]]++;
            //}
            //for (int i = 0; i < arr.Length; i++) {
            //    if(freq[arr[i]] != 0)
            //    {
            //        Console.WriteLine(arr[i] + " repeated " + freq[arr[i]]);
            //        freq[arr[i]] = 0;
            //    }
            //}
            #endregion



            #region Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] arr = { 1, 2, 3, 2, 4, 5, 6, };
            //int max = arr[0];
            //int min = arr[0];
            //for (int i = 0; i < arr.Length; i++) {
            //    if (arr[i] > max) {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min) { 
            //    min = arr[i];
            //    }
            //}
            //Console.WriteLine("the max is " + max);
            //Console.WriteLine("the min is " + min);
            #endregion


            #region  Write a program in C# Sharp to find the second largest element in an array.
            //int[] arr = { 1,  3, 2, 4, 5, 6, };
            //Array.Sort(arr);
            //Console.WriteLine("the secod max ele " + arr[arr.Length-2]);
            #endregion


            #region Consider an Array of Integer values with size N, having values as in this Example
            //int siz = int.Parse(Console.ReadLine());
            //int[]arr = new int[siz];
            //for (int i = 0; i < siz; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int len = -1;
            //for (int i = 0; i < siz; i++) {
            //    for (int j = i+1; j < siz; j++) {
            //        if (arr[i] == arr[j] && (j - i)>len) {
            //            len = j - i;
            //        }
            //    }
            //}
            //Console.WriteLine(len);
            #endregion


            #region Given a list of space separated words, reverse the order of the words.
            //string s = Console.ReadLine();
            //string[] arr;
            //arr = s.Split(" ");
            //Array.Reverse(arr);
            //Console.WriteLine(String.Join(" ", arr));

            #endregion


            #region  Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //int[,] arr = new int[3, 3];
            //int[,] arr2 = new int[3, 3];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < arr.GetLength(0); i++) 
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++) 
            //    {
            //        arr2[i, j] = arr[i, j];
            //    }
            //}
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine(arr2[i, j]);
            //    }
            //}
            #endregion


            #region  Write a Program to Print One Dimensional Array in Reverse Order
            //int[] arr = { 1, 2, 3 };
            //for (int i = arr.Length-1; i >= 0; i--) {
            //    Console.WriteLine(arr[i]);
            //}
            #endregion


            #region   Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            /*
             each function has its space in stack when you pass the elements by value 
            the main elements don't change because any change is made in the another functino 
            space in the stack but in the pass by referance we don't pass the vlue of the element we pass the
            address so any change will affect the elements in the stack
             */

            //int a = 3;
            //int b = 5;
            //swapbyvalue(a, b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //swapbyref(ref a, ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);


            #endregion




            #region Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(print_th_sum_digits(num)); 
            #endregion


            #region  Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not 
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(isprime(num));
            #endregion



            #region Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter 
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(fact(num));
            #endregion


            #region Create a function named "ChangeChar" to modify a letter in a       certain position (0 based) of a string, replacing it with a different letter .
            string s = Console.ReadLine();
            
            int pos = int.Parse(Console.ReadLine());
            char x = char.Parse(Console.ReadLine());

            Console.WriteLine(changechar(s, x, pos));
            
            
            #endregion

        }
    }
}
