// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int x = 2;
//         int y = 3;
//         int sum = Adder(x, y);

//         GreetUser("Bob");

//         string someonesName = "Jill";
//         GreetUser(someonesName);

//         Console.WriteLine($"x before = {x} ");
//         ChangeValue(x);
//         Console.WriteLine($"x after = {x} ");

//         int[] myArray = new int[] { 1, 2, 3, 4, 5 };
//         foreach (int number in myArray)
//         {
//             Console.Write($"{number} ");
//         }

//         changeReference(myArray);
//         Console.Write("After: ");
//         foreach (int number in myArray)
//         {
//             Console.Write($"{number} ");
//         }
//     }

//     static void ChangeValue(int x)
//     {
//         x = 100;
//     }

//     static void changeReference(int[] data)
//     {
//         data[2] = 100;
//     }

//     // def adder(a, b):
//     // return a + b

//     static int Adder(int a, int b)
//     {
//         return a + b;
//     }

//     static void GreetUser(string firstName)
//     {
//         Console.WriteLine($"Hello {firstName}!");
//     }

// }