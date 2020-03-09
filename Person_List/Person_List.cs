using System;

namespace Person_List
{
   public class Person_List { 
  
    // Instance Variables 
    String name; 
    int age; 

  
    // Constructor Declaration of Class 
    public Person_List(String name,  
                  int age) 
    { 
        this.name = name; 
       
        this.age = age; 
        
    } 
  
    // Property 1 
    public String getName() 
    { 
        return name; 
    } 
  
    // Property 2 

  
    // Property 3 
    public int getAge() 
    { 
        return age; 
    } 
  
    // Property 4 

  
    // Method 1 
    public String toString() 
    { 
        return ("Hi my name is " + this.getName() 
                + ", " +"i am "+ this.getAge()+ "years old"); 
    } 
  
// Main Method 
public static void Main(String[] args) 
    { 
          
        // Creating object 
        Person_List newList = new Person_List("Yemisrach", 5); 
        Console.WriteLine(newList.toString()); 
    } 
} 
}