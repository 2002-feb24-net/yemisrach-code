using System;

namespace acronmy
{
    class Program
    {
        static String firstLetterWord(String str)  
    {  
        String result = "";  
  
        // Traverse the string.  
        bool v = true;  
        for (int i = 0; i < str.Length; i++)  
        {  
            // If it is space, set v as true.  
            if (str[i] == ' ')  
            {  
                v = true;  
            }  
              
            // Else check if v is true or not.  
            // If true, copy character in output  
            // string and set v as false.  
            else if (str[i] != ' ' && v == true)  
            {  
                result += (str[i]);  
                v = false;  
            }  
        }  
        return result;  
    }  
  
    // Driver code  
    public static void Main()  
    {  
        // String str = "geeks for geeks";  
        // Console.WriteLine(firstLetterWord(str));  
        Console.WriteLine("write any sentense?");
        string str=Console.ReadLine();  
       
        firstLetterWord(str);
         Console.WriteLine(firstLetterWord(str));
    }  
}  
}