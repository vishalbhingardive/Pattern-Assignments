Console.WriteLine("Enter the String:");
string s= Console.ReadLine();

Console.WriteLine(s+":"+IsPalindrome(s));
s = "nutan";
Console.WriteLine(s+":"+IsPalindrome(s));
 bool IsPalindrome(string s)
{
    int start = 0;
    int end = s.Length-1;
    while (start < end)
    {
        if (s[start++] != s[end--])
        {
            return false;
        }
    }
         return true;
        

}