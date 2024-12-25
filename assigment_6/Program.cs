namespace assigment_6
{
    internal class Program

    {
        static void changebyvalue(int[] arr)
        {
            arr[0] = 100;
        }
        static void changebyref(ref int[] arr)
        {
            arr[0] = 100;
        }

        static void calc(int num1 , int num2 , int num3 ,int num4 , out int sum , out int sub)
        {
            sum = num1 + num2;
            sub = num3 - num4;
        }
        static void minmaxarr(int[] arr , ref int min , ref int max) {
            if(arr is not null)
            {
                for (int i = 0; i < arr?.Length; i++)
                {
                    if (arr[i] > max)
                        max = arr[i];

                    if (arr[i] < min)
                        min = arr[i];
                }
            }
        }
        static void Main(string[] args)
        {

            #region Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            /*
             when you pass the reference type by value you acctuly pass the address of the value 
            he point to it in the heap 
            but when you pass the reference type be referece you pass the address of the variable
            in the stack that point to the value in  the heap
             */

            //pass value
            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine(arr[0]);
            //changebyvalue(arr);
            //Console.WriteLine(arr[0]);

            ///////////////////////////////////
            //by reference
            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine(arr[0]);
            //changebyref(ref arr);
            //Console.WriteLine(arr[0]);

            #endregion



            #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //    int num1 = int.Parse(Console.ReadLine());
            //    int num2 = int.Parse(Console.ReadLine());
            //    int num3 = int.Parse(Console.ReadLine());
            //    int num4 = int.Parse(Console.ReadLine());

            //calc(num1, num2, num3, num4, out int sum, out int sub);
            //Console.WriteLine(sum);
            //Console.WriteLine(sub);
            #endregion


            #region Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] arr = { 3, 2, 4, 1, 5 };
            //int min = arr[0];
            //int max = arr[0];
            //minmaxarr(arr , ref min , ref max);
            //Console.WriteLine($"the min is {min}");
            //Console.WriteLine($"the max is {max}");
            #endregion
        }
    }
}
