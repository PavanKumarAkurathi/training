//var firstname = "Pavan";
//var lastname = "Kumar";
//Console.WriteLine("firstname");
//Console.WriteLine($"{firstname}, {lastname}");
//int age =26;
//double salary = 467859.24;
//bool ismale = true;
//Console.WriteLine($"Age is {age}, Salary is {salary}, he is male {ismale}");
//int a = 10;
//int b =15;
//Console.WriteLine ($"Sum of a + b is { a + b }");
//Console.WriteLine (a/b);
//Console.WriteLine (a%b);
//Console.WriteLine(a==b);
//Console.WriteLine(a!=b);
//Console.WriteLine(a>=b);
//Console.WriteLine(a<=b);
//Console.WriteLine(a>b);
//Console.WriteLine(a<b);
//Console.WriteLine((a==b) &&  (a!=b));
//Console.WriteLine("Enter x value ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter y value ");
//int y = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Sum of x + y is {x+y}");



//Loops:
//Write a C# code to accept two integers and check whether they are equal or not.

//Console.WriteLine("Enter o value ");
//int o = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter p value");
//int p = Convert.ToInt32(Console.ReadLine());
//if ( o == p)
//{
//    Console.WriteLine(" o and p are equal ");
//}
//else
//{
//    Console.WriteLine("o and p are not equal");
//}

//Write a C# Sharp program to find the largest of three numbers.

// Console.WriteLine("Enter o value ");
// int o = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter p value ");
// int p = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter q value ");
// int q = Convert.ToInt32(Console.ReadLine());
// if ( o > p && o > q)
// {
//    Console.WriteLine("o is Larger number");
// }
// else if ( p > o && p > q)
// {
//    Console.WriteLine("P is the larger number");
// }
// else
// {
//    Console.WriteLine("q is the larger number");
// }



//Write a switch statement that takes an integer variable representing a day of the week (1 for Monday, 2 for Tuesday, etc.) and prints the corresponding day name.
// Console.WriteLine("Enter the day of the Week");
// int day = Convert.ToInt32(Console.ReadLine());
// switch (day)
// {
//     case 1:
//     Console.WriteLine("Monday");
//     break;
//     case 2:
//     Console.WriteLine("tuesday");
//     break;
//     case 3:
//     Console.WriteLine("wednesday");
//     break;
//     case 4:
//     Console.WriteLine("thursday");
//     break;
//     case 5:
//     Console.WriteLine("friday");
//     break;
//     case 6:
//     Console.WriteLine("saturday");
//     break;
//     case 7:
//     Console.WriteLine("sunday");
//     break;
//     default:
//     Console.WriteLine("Invalid day ");
//     break;
// }



//Write a program in C# Sharp to display the first 10 natural numbers using for loop.

// for (int i=1;i<=10;i++)
// {
//     Console.WriteLine($"The first 10 natural numbers are {i}");
// }

//Write a C# Sharp program to find the sum of the first 10 natural numbers using for loop.
// int sum =0;
// for (int i=1;i<=10;i++)
// {
//     sum = sum + i;
// }
// Console.WriteLine($"Sum of first 10 natural numbers is {sum}");


//Write a program that takes a positive integer input from the user and calculates the sum of its digits using a loop.
Console.WriteLine("Enter the Number ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if ( n < 0)
{
    Console.WriteLine("Invalid Number ");
}
else
{
    while ( n > 0)
    {
        int a = n % 10;
        sum = sum + a;
        n = n/10;
    }
  Console.WriteLine($"Sum of digits is {sum}");
}
