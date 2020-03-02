using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
             {  
        int n = 1000; 
  
       
        for (int i = 1; i <= n; i++)                              
        { 
           
            if (i % 15 == 0)  
                Console.Write("FizzBuzz" + " ");  
  
           
            else if (i % 3 == 0)      
                Console.Write("Fizz" + " ");  
  
            else if (i % 5 == 0)                                              
                Console.Write("Buzz" + " ");  
              
            
            else
                Console.Write(i + " ");                      
        } 
    } 
} 
  


    }
 
}
//267 fizz
//134 buzz 
//67 fizzbuzz