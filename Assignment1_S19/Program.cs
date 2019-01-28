using System;

namespace Assignment1_S19
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //to prints all the prime numbers between x and y
                Console.WriteLine("Enter the starting range x value: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the ending range y value: ");
                int y = int.Parse(Console.ReadLine());
                PrintPrimeNumbers(x, y);  //Calling the method PrintPrimeNumbers with x and y as arguments.

                //to compute the series
                Console.WriteLine("\nEnter the number of terms of the series ");
                int n1 = int.Parse(Console.ReadLine());
                double r1 = GetSeriesResult(n1); //Calling the method GetSeriesResult with n1 as argument.
                Console.WriteLine("The sum of series is: " + r1);

                //to convert a number from decimal (base 10) to binary (base 2)
                Console.WriteLine("Enter the non-negative number to be converted to binary: ");
                long n2 = long.Parse(Console.ReadLine());
                long r2 = DecimalToBinary(n2); //Calling the method DecimalToBinary with n2 as argument.
                Console.WriteLine("binary conversion for " + n2 + " is " + r2);


                //to convert a number from binary(base 2) to decimal(base 10)
                Console.WriteLine("Enter the non-negative binary number to be converted to decimal: ");
                long n3 = long.Parse(Console.ReadLine());
                long r3 = BinaryToDecimal(n3); //Calling the method BinaryToDecimal with n3 as argument.
                Console.WriteLine("decimal conversion for " + n3 + " is " + r3);


                //to print a triangle using *
                Console.WriteLine("Enter the number of lines for the pattern: ");
                int n4 = int.Parse(Console.ReadLine());
                PrintTriangle(n4); //Calling the method PrintTriangle with n4 as argument.


                //to compute the frequency of each element in the array
                Console.WriteLine("Enter number of elements you want to enter into array: ");
                int a = int.Parse(Console.ReadLine());
                int[] arr = new int[a];
                Console.WriteLine("Enter the values into the array\n");
                for (int i=0;i<a;i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                ComputeFrequency(arr); //Calling the method ComputeFrequency with arr as argument.


                Console.ReadKey(true);
            } //End of Try
            catch
            {
                Console.WriteLine("Please enter a valid input");
                Console.ReadKey(true); 
            } //End of catch
        } //End of Main

        /*
         Self-reflection:
         1. This assignment demands learning C# basics like,
          - Conditional statements
          - Iterative statements
          - Method declaration and calling
          - Array declaration and population
         2. This assignment helped me in understanding the essence of Console.WriteLine, which is a great help  
            in solving logical errors.
         3. This assignment made sure I understand the errors and the ways to solve them.
         
         Recommendations:
         1. More questions on topic arrays should have been included (atleast one more question).
         2. Instead of asking for just a factorial method, a factorial method using recursion would have been more interesting.
         3. Instead of triangle with *, a triangle with number series would have been more interesting. */

        public static void PrintPrimeNumbers(int x, int y)
        {
            try
            {
                /*If user by chance mistook lower limit to upper limit 
                 * and vice-versa, this 'if' block is to swap the inputs. */
                if(x>y)
                {
                    x = x + y;
                    y = x - y;      //Swap code
                    x = x - y;

                }
                for (int i = x; i <= y; i++)
                {
                   IsPrime(i); //IsPrime method is being called with i as a passing argument.
                }

            } //End of try
            catch
            {
                Console.WriteLine("Exception occured while computing PrintPrimeNumbers method");
            } //End of catch

        } //End of printPrimeNumbers


        public static void IsPrime(int k)
        {
            try
            {
                /*For a number to know if it is a prime or not; if that number is not divisible by
                 * the numbers below half the given number, then it is prime.*/
                 
                int n;
                int count = 0;
                if (k % 2 != 0) //To check if the number is odd, so that we can add one to make it even
                {
                    n = k + 1;
                    n = n / 2;
                }
                else
                {
                    n = k / 2;
                }
                for (int i = 2; i <= n; i++) //Checking divisibility by numbers below half the given number 
                {
                    if (k % i == 0)
                    {
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                } // End of for loop
                if (count == 0) // if count is 0, then the number is prime
                {
                    Console.Write(k + " ");
                }
            } //End of try
            catch
            {
                Console.WriteLine("Exception occured while computing IsPrime method");

            }//End of catch


        }// End of isPrime


        public static double GetSeriesResult(int n)
        {
            try
            {
                double r = 0;
                for (int i = 1; i <= n; i++)
                {
                    r = r + Math.Pow(-1, i + 1) * (Factorial(i) / (i + 1)); //As per given series formula
                }
                return Math.Round(r, 3); // output is rounded to 3 decimals
            } //End of try
            catch
            {
                Console.WriteLine("Exception occured while computing IsPrime method");
                return (0);
            }//End of catch

        }//End of getSeriesResult


        public static double Factorial(int x)
        {
            try
            {
                double y = 1;
                for (int i = 1; i <= x; i++)
                {
                    y = y * i; //iterative multiplication, with variable being decremented
                }
                return y;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Factorial method");
                return (0);
            }//End of catch
        }//End of factorial


        public static long DecimalToBinary(long n)
        {
            try
            {
                long i = 1, d = 0;
                long r = 0;
                while (n != 0)
                {
                    r = n % 2; //For every iteration r will hold the value of the reminder
                    n = n / 2; //For every iteration the value of n will be reduced by half
                    d += i * r;
                    i *= 10; //As the remainders to be added in decimal places for the result
                }
                return d;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Factorial method");
                return (0);
            }//End of catch

        }//End of DecimalToBinary


        public static long BinaryToDecimal(long n)
        {
            try
            {
                long d, x = 0;
                long count = 0;
                while (n != 0)
                {
                    d = n % 10; //For every iteration d will hold the value of the reminder
                    n = n / 10; //For every iteration the value of n will be reduced by one tenth
                    x += d * Two_Power(count); // method Two_Power is being called with count as passing argument
                    count++;
                }
                return x;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Factorial method");
                return (0);
            }//End of catch

        }// End of BinaryToDecimal

        public static long Two_Power(long n)
        {
            try
            {
                long d = 1;
                if (n > 0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        d = d * 2; //iterative multiplication of d with 2 is being performed
                    }
                    return d;
                }
                else
                {
                    return 1; //for n=0
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Factorial method");
                return (0);
            }//End of catch

        } // End of two power


        public static void PrintTriangle(int n)
        {
            try
            {
                for (int k = 1; k <= n; k++) 
                {
                    for (int i = n - k; i >= 0; i--) //will print space till n-k spots, where n is number of the line
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= 2 * k - 1; j++) //will print * till 2k-1 times
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Factorial method");

            }//End of catch

        }//End of PrintTriangle


        public static void ComputeFrequency(int[] a)
        {
            try
            {
                int[] b = new int[a.Length]; //initialization of an array b of length a
                int count;
                for (int i = 0; i < a.Length; i++) //population of the created array with 1
                {
                    b[i] = 1;
                }
                for (int i = 0; i < a.Length; i++)
                {
                    count = 1;
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++; //To keep track of the frequency
                            b[j] = 0; //If the number matches, then b[j] is set to 0, thereby differentiating them from others
                        }
                    }

                    if (b[i] != 0)
                    {
                        b[i] = count; //frequency is stored in the array b
                    }
                }

                Console.WriteLine("Number\tFrequency");
                for (int i = 0; i < a.Length; i++)
                {
                    if (b[i] != 0)
                    {
                        Console.WriteLine(a[i] + "\t" + b[i]);
                    }
                }
            }//End of try
            catch
            {
                Console.WriteLine("Exception occured while computing Factorial method");

            }//End of catch

        }
    }
}
