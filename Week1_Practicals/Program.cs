// I have checked that this code works im saving all tasks as comments to avoid problems with defining variables, works well for short practicals such as this


//Task 1:

//Console.WriteLine("What's your name?");
// Name = Console.ReadLine();
//Console.WriteLine("How old are you");
//int age = Convert .ToInt32(Console.ReadLine());
//int years = 30 - age;
//Console.WriteLine("Hi " + Name + " you will be 30 in " + years + " years");

//Task 2
//Console.WriteLine("How old are you");
//int age = Convert.ToInt32(Console.ReadLine());

//if (age < 13){
//    Console.WriteLine("You are but a child");
//}
//else if (age >= 13 && age < 19)
//{
//    Console.WriteLine("You are a teen");
//}
//else if  (age >= 19 && age < 111)
//{
//    Console.WriteLine("You full grown");
//}
//else
//{
//    Console.WriteLine("Please enter a valid age");
//}

//Task 3
using System.ComponentModel.Design;

//Console.WriteLine("Please enter an integer");
//int WholeNumber = Convert.ToInt32(Console.ReadLine());

//if (WholeNumber < 0)
//{
//    Console.WriteLine("That is a negative integer");
//}
//else if (WholeNumber > 0)
//{
//    Console.WriteLine("That is a positive integer");
//}
//else if (WholeNumber == 0) 
//{
//    Console.WriteLine("This MIGHT be zer0");
//}
//else
//{
//    Console.WriteLine("Please enter a valid integer");
//}

//Task 4
Console.WriteLine("Please enter a year");
int year = Convert.ToInt32(Console.ReadLine());

if (year % 4 == 0 && year % 100 != 0 || year % 400 ==0)
{
    Console.WriteLine("This is a leap year"); 
}                              //There's definitely a way to make this look nicer through methods but this work

else if (year < 0)
{
    Console.WriteLine("Please enter a valid year");
}
else
{
    Console.WriteLine("This is not a leap year");
}

//Task 5
Console.WriteLine("Please enter a number");
int number  = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("This is an even number");
}
else if (number% 2 != 0)
{
    Console.WriteLine("This is an odd number");
}
else
{
    Console.WriteLine("Please enter a valid number");
}