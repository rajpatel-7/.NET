using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.(A) Write a program to Create a divide by zero exception and handle it.

            //int a=5,b=0;
            //try
            //{
            //    int ca = a / b;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Error Massage: "+ ex.Message);
            //}

            //2.(A) Write a program that reads 5 numbers from user.Demonstrate concept of IndexOutOfRange Exception.

            //int[] numbers = new int[5];

            //Console.WriteLine("Enter 5 numbers:");
            //for (int i = 0; i < 5; i++)
            //{
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //try
            //{
            //    Console.WriteLine("Trying to access an invalid index...");
            //    Console.WriteLine(numbers[5]); 
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Exception caught: " + ex.Message);
            //}

            //3.(A) Write a program to create an abstract class Sum having abstract methods SumOfTwo(int a, int b) and SumOfThree(int a, int b,
            //    int c). Create another class Calculate which extends the abstract class and implements the abstract methods.

            //Calculate calc = new Calculate();

            //Console.WriteLine("Sum of 2 numbers (5, 10): " + calc.SumOfTwo(5, 10));
            //Console.WriteLine("Sum of 3 numbers (3, 6, 9): " + calc.SumOfThree(3, 6, 9));

            //4.(A) Write a program to create interface Calculate. In this interface we have two member functions Addition() and Subtraction(). 
            //Implements this interface in another class named Resule.

            //Result res = new Result();

            //Console.WriteLine("Addition of 10 and 5: " + res.Addition(10, 5));
            //Console.WriteLine("Subtraction of 10 and 5: " + res.Subtraction(10, 5));

            //5.(A) Write program showing use of common methods of String class.

            //string str1 = "Hello, World!";
            //string str2 = "  C# Programming  ";

            //Console.WriteLine("Length of str1: " + str1.Length);

            //Console.WriteLine("Uppercase: " + str1.ToUpper());

            //Console.WriteLine("Lowercase: " + str1.ToLower());

            //Console.WriteLine("Trimmed str2: '" + str2.Trim() + "'");

            //Console.WriteLine("Substring (Hello): " + str1.Substring(0, 5));

            //Console.WriteLine("Replaced string: " + str1.Replace("World", "C#"));

            //string[] words = str1.Split(' ');
            //Console.WriteLine("Words after split:");
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}

            //Console.WriteLine("Contains 'World'?: " + str1.Contains("World"));

            //Console.WriteLine("Index of 'o': " + str1.IndexOf('o'));

            //Console.WriteLine("Starts with 'Hello'?: " + str1.StartsWith("Hello"));

            //Console.WriteLine("Ends with '!'?: " + str1.EndsWith("!"));

            //Console.WriteLine("Concatenated string: " + string.Concat(str1, " Welcome to C#!"));

            //6.(B) Write a program to Replace lower case characters to upper case and Vice-versa.

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();
            //string result = "";

            //foreach (char ch in input)
            //{
            //    if (char.IsLower(ch))
            //        result += char.ToUpper(ch); // Convert lowercase to uppercase
            //    else if (char.IsUpper(ch))
            //        result += char.ToLower(ch); // Convert uppercase to lowercase
            //    else
            //        result += ch; // Keep non-alphabetic characters unchanged
            //}

            //Console.WriteLine("Modified string: " + result);

            //7.(B) Write a program to create interface named Shape.In this interface, we have three methods Circle(), Triangle() and Square()
            //which calculates area of Circle, Triangle and Square respectively.Implement Shape interface.

            //AreaCalculator calc = new AreaCalculator();

            //Console.WriteLine("Area of Circle with radius 5: " + calc.Circle(5));
            //Console.WriteLine("Area of Triangle with base 6 and height 4: " + calc.Triangle(6, 4));
            //Console.WriteLine("Area of Square with side 3: " + calc.Square(3));

            //8.(B) Write a program to accept a number from the user and throw an exception if the number is not an even number.

            //try
            //{
            //    Console.Write("Enter a number: ");
            //    int number = int.Parse(Console.ReadLine());

            //    if (number % 2 != 0)
            //    {
            //        throw new Exception("The number is not even.");
            //    }

            //    Console.WriteLine("The number is even.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception: " + ex.Message);
            //}

            //9.(C) Write a program to nd the longest word in a string.

            //Console.Write("Enter a sentence: ");
            //string input = Console.ReadLine();

            //string[] words = input.Split(' ');
            //string longest = "";

            //foreach (string word in words)
            //{
            //    if (word.Length > longest.Length)
            //    {
            //        longest = word;
            //    }
            //}

            //Console.WriteLine("The longest word is: " + longest);

            //10.(C) Write a program to change the case of entered character.

            //Console.Write("Enter a character: ");
            //string input = Console.ReadLine();

            //if (input.Length != 1 || !char.IsLetter(input[0]))
            //{
            //    Console.WriteLine("Please enter a single alphabetic character.");
            //}
            //else
            //{
            //    char ch = input[0];
            //    if (char.IsUpper(ch))
            //    {
            //        Console.WriteLine("Lowercase: " + char.ToLower(ch));
            //    }
            //    else
            //    {
            //        Console.WriteLine("Uppercase: " + char.ToUpper(ch));
            //    }
            //}

            Console.ReadLine();
        }
    }
}
