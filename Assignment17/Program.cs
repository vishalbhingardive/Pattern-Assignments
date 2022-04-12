// int a = 2147483647;


//Console.WriteLine(a);
//a += 200;
//Console.WriteLine(a);

//string s = "hello World!";
//Console.WriteLine("========");
//Console.WriteLine(s.Length);

//int @int = 10;
//Console.WriteLine(@int);

//string s1 = "hElLo";

//Console.WriteLine(s1.ToLower());
//Console.WriteLine(s1.ToUpper());

//string s2 = "11,53,63,3";
//string[] s3 = s2.Split(",");
//Console.WriteLine(s3[0]);


//var a = "Hello";
//var b = "World";
//Console.WriteLine("    ");
//Console.WriteLine("Value Of a "+a+"\t  Value Of b  "+b);
//Console.WriteLine("    ");
//Console.WriteLine("Value Of a "+a+"\n\n Value Of b  "+b);

//Console.WriteLine("Enter Number");
//int a=int.Parse(Console.ReadLine());
//if (a % 5 == 0)
//{
//    if (a % 2 == 0)
//    {
//        Console.WriteLine($"{a} is Divided by both 5 & 2");
//    }
//    else
//    {
//        Console.WriteLine("Sorry!!");
//    }
//}
//else
//{
//    Console.WriteLine("Sorry!!");
//}


//Console.WriteLine("Enter Number");
//int a = int.Parse(Console.ReadLine());
//if (a == 0)
//{
//    Console.WriteLine("Sunday");

//}
//else if(a == 1)
//{
//    Console.WriteLine("Monday");
//}
//else if(a==2)
//{
//    Console.WriteLine("Tuesday");
//}
//else if(a==3)
//{
//    Console.WriteLine("Wednesday");
//}

//else if (a == 4)
//{
//    Console.WriteLine("Thursday");
//}

//else if (a == 5)
//{
//    Console.WriteLine("Friday");
//}

//else if(a==6)
//{
//    Console.WriteLine("Saturday");
//}
//else
//{
//    Console.WriteLine("Invalid Choice");
//}




//Console.WriteLine("Enter Number");
//int a = int.Parse(Console.ReadLine());
//if (a == 0)
//{
//    Console.WriteLine("31");

//}
//else if (a == 1)
//{ 
//        Console.WriteLine("28");
//}
//else if (a == 2)
//{
//    Console.WriteLine("31");
//}
//else if (a == 3)
//{
//    Console.WriteLine("30");
//}

//else if (a == 4)
//{
//    Console.WriteLine("31");
//}

//else if (a == 5)
//{
//    Console.WriteLine("30");
//}

//else if (a == 6)
//{
//    Console.WriteLine("31");
//}
//else if (a == 7)
//{
//    Console.WriteLine("30");
//}
//else if (a == 8)
//{
//    Console.WriteLine("31");
//}
//else if (a == 9)
//{
//    Console.WriteLine("30");
//}

//else if (a == 10)
//{
//    Console.WriteLine("31");
//}

//else if (a == 11)
//{
//    Console.WriteLine("30");
//}

//else
//{
//    Console.WriteLine("Invalid Choice");
//}



//Console.WriteLine("Enter Month");
//string a=Console.ReadLine().ToLower();

//if (a=="jan" )
//{
//    Console.WriteLine($"There are 31 Days in {a}");

//}
//else if (a == "feb")
//{
//    Console.WriteLine($"There are 28 Days in{a}");
//}
//else if (a == "mar")
//{
//    Console.WriteLine("There are 31 Days in");
//}
//else if (a == "apr")
//{
//    Console.WriteLine($"There are 30 Days in{a}");
//}

//else if (a == "may")
//{
//    Console.WriteLine($"There are 31 Days in{a}");
//}

//else if (a == "june")
//{
//    Console.WriteLine($"There are 30 Days in{a}");
//}

//else if (a == "jul")
//{
//    Console.WriteLine($"There are 31 Days in{a}");
//}
//else if (a == "aug")
//{
//    Console.WriteLine($"There are 30 Days in {a}");
//}
//else if (a == "sept")
//{
//    Console.WriteLine($"There are 31 Days in{a}");
//}
//else if (a == "oct")
//{
//    Console.WriteLine($"There are 30 Days in{a}");
//}

//else if (a == "nov")
//{
//    Console.WriteLine("31");
//}

//else if (a == "dec")
//{
//    Console.WriteLine("30");
//}

//else
//{
//    Console.WriteLine("Invalid Choice");
//}


string a = Console.ReadLine().ToLower();
switch (a)
{
    case "jan":
        Console.WriteLine($"There are 31 Days in {a}");
        break;
    case "feb":
        Console.WriteLine($"There are 28 Days in {a}");
        break;
    case "mar":
        Console.WriteLine($"There are 31 Days in {a}");
        break;
    case "may":
        Console.WriteLine($"There are 30 Days in {a}");
        break;
    case "jun":
        Console.WriteLine($"There are 31 Days in {a}");
        break;
    case "jul":
        Console.WriteLine($"There are 30 Days in {a}");
        break;
    case "aug":
        Console.WriteLine($"There are 31 Days in {a}");
        break;
    case "sept":
        Console.WriteLine($"There are 30 Days in {a}");
        break;
    case "oct":
        Console.WriteLine($"There are 31 Days in {a}");
        break;
    case "nov":
        Console.WriteLine($"There are 30 Days in {a}");
        break;
    case "dec":
        Console.WriteLine($"There are 31 Days in {a}");
        break;
    default:
        break;
}


Console.WriteLine("Enter Number");
int z = int.Parse(Console.ReadLine());
string result = z % 5 == 0 ? z % 2 == 0 ? "Done" : "Sorry" : "Nothing";
Console.WriteLine(result);






