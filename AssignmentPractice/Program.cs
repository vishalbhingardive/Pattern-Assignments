//1.Take three numbers from the user and print the greatest number 

//Console.WriteLine("Enter Number");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter Second Number");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter Third Number");
//int c = int.Parse(Console.ReadLine());

//if (a > b && a > c)
//    Console.WriteLine($"Greatest Number is {a}");
//else if (b > c && b > a)
//    Console.WriteLine($"Gretest Number is {b}");
//else if(c>a && c>b)
//    Console.WriteLine($"Gretest Number is {c}");
//else if(a==b)
//    Console.WriteLine("A And B Both are Equal");
//else if(b==c)
//    Console.WriteLine("B And C Both Equal");
//else if(a==c)
//    Console.WriteLine("A And C Both Equal");
//else
//    Console.WriteLine("Invalid Value");


//2.Write a C# program that reads a floating-point number and prints "zero" if the number is zero. Otherwise, print "positive" or "negative". Add "small" if the absolute value of the number is less than 1, or "large" if it exceeds 1,000,000. 

//Console.WriteLine("Enter Float Value");
//float f = float.Parse(Console.ReadLine());

//if (f == 0)
//{
//    Console.WriteLine($"Number is Zero");
//}
//else if (f < 0)
//{
//    Console.WriteLine($"Value is Negative And To Small {f}");
//}
//else if (f > 1000000)
//{
//    Console.WriteLine($"Value Is Positive And To Large {f}");
//}
//else
//{
//    Console.WriteLine($"Value Is Positive {f}");
//}

//3. Write a C# program that keeps a number from the user and generates an   integer between 1 and 7 and displays the name of the weekday 

//Console.WriteLine("Enter Number of Day");
//int z = int.Parse(Console.ReadLine());

//string result = z == 0 ? "Sunday" : z == 1 ? "Monday" : z == 2 ? "Tuesday" : z == 3 ? "Wednesday" : z == 4 ? "Thursday" : z == 5 ? "Friday" : z == 6 ? "saturday" : "invalid";
//Console.WriteLine(result);


//4. Take month and year as input from a user and print the number of days in that particular month. 

//Console.WriteLine("Enter Year");
//int y = int.Parse(Console.ReadLine());
//bool a = false;
//if (y % 4 == 0)
//{
//    a = true;
//    Console.WriteLine("Year is Leap");
//}
//else
//    Console.WriteLine("Year is Normal");
//Console.WriteLine("Enter Month");
//string m = Console.ReadLine().ToLower();
//if (m == "jan")
//{
//    Console.WriteLine($"There are 31 Days in {m}");
//}
//else if (m == "feb" && a)
//{
//    Console.WriteLine($"There are 29 Days in {m}");


//}
//else if (m == "mar")
//{
//    Console.WriteLine($"There are 31 Days in {m}");
//}
//else if (m == "apr")
//{
//    Console.WriteLine($"There are 30 Days in {m}");
//}
//else if (m == "may")
//{
//    Console.WriteLine($"There are 31 Days in {m}");
//}
//else if (m == "june")
//{
//    Console.WriteLine($"There are 30 Days in {m}");
//}
//else if (m == "jul")
//{
//    Console.WriteLine($"There are 31 Days in {m}");
//}
//else if (m == "aug")
//{
//    Console.WriteLine($"There are 31 Days in {m}");
//}
//else if (m == "sept")
//{
//    Console.WriteLine($"There are 30 Days in {m}");
//}
//else if (m == "oct")
//{
//    Console.WriteLine($"There are 31 Days in {m}");
//}
//else if (m == "nov")
//{
//    Console.WriteLine($"There are 30 Days in {m}");
//}
//else if (m == "dec")
//{
//    Console.WriteLine($"There are 31 Days in {m}");
//}
//else
//{
//    Console.WriteLine($"These Month Have 28 Days");
//}


Console.WriteLine("Enter Year");
int e = int.Parse(Console.ReadLine());
bool n = false;

Console.WriteLine("Year is Normal");
Console.WriteLine("Enter Month");



string h = Console.ReadLine().ToLower();
switch (h)
{
    case "jan":
        Console.WriteLine($"There are 31 Days in {h}");
        break;
    case "feb":
        if (e % 4 == 0 && e%400==0)
        {
            Console.WriteLine($"There are 28 Days in {h}");
        }
        else
        {
            Console.WriteLine($"There Are 28 Days in {h}");
        }
        break;
    case "mar":
        Console.WriteLine($"There are 31 Days in {h}");
        break;
    case "may":
        Console.WriteLine($"There are 30 Days in {h}");
        break;
    case "jun":
        Console.WriteLine($"There are 31 Days in {h}");
        break;
    case "jul":
        Console.WriteLine($"There are 30 Days in {h}");
        break;
    case "aug":
        Console.WriteLine($"There are 31 Days in {h}");
        break;
    case "sept":
        Console.WriteLine($"There are 30 Days in {h}");
        break;
    case "oct":
        Console.WriteLine($"There are 31 Days in {h}");
        break;
    case "nov":
        Console.WriteLine($"There are 30 Days in {h}");
        break;
    case "dec":
        Console.WriteLine($"There are 31 Days in {h}");
        break;
    default:
        break;
}


