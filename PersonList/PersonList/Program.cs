using System;

namespace PersonList
{
    class Program
    {

        static void Main(string[] args)
        {
            Person newperson = new Person();
            newperson.full_Name("yemisrach_mekuria");
            newperson.age("23");
            // Console.WriteLine(str.ToString()); 
            
            // Console.WriteLine("myname is "+ st.ToString().Getfull_Name()); 
            //  Console.WriteLine("i am "+ st.ToString().Getage()); 
          Console.WriteLine("myname is "+newperson.full_Name);
        }

         public class Person
   {
            private string full_Name;
            private int age;

            // public Person(string full_Name,int age) {
    
      public int full_Name { get; set; }
      public int age { get; set; }
      }
    }
}
