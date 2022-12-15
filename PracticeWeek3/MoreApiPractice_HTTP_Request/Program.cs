namespace MoreApiPractice_HTTP_Request;
using System;
using System.Collections.Generic;
using System;
using System.Reflection;

class Program {
   static int PlusMethod(int x, int y){
      return x + y;
   }

   static double PlusMethod(double x, double y){
      return x + y;
   }

   static void Main(string[] args) {
      int myNum1 = PlusMethod(9, 13);
      double myNum2 = PlusMethod(6.2, 4.34);
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);
    }  
  }