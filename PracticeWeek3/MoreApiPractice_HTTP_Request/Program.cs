namespace MoreApiPractice_HTTP_Request;
using System;
using System.Collections.Generic;
using System;
using System.Reflection;

public class Program
{

    public static void Main()
    {
        String studentName = "Jack";

        //get the current type of studentName
        Type studentNameType = studentName.GetType();

        Console.WriteLine("\nType is: " + studentNameType + "\n");

        //get typeof the Program class and load it to Type variable t     
        Type t = typeof(Program);

        //get Assembly of variable t using the Assembly property
        Console.WriteLine(t.Assembly);

        //get typeof String and load it to Type variable t     
        Type t2 = typeof(String);

        //the Type class properties return information about the String Type 
        Console.WriteLine("\nName : {0}", t2.Name);
        Console.WriteLine("Namespace : {0}", t2.Namespace);
        Console.WriteLine("Base Type : {0}", t2.BaseType);

        Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        

        
    }
}

internal class Cloud
{
   private string Name { get; set; } = "Cloud";
   private int HP { get ; set; } = 100;

}