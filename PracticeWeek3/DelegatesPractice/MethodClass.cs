using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DelegatesPractice
{
    public class MethodClass
    {
        public string AppendString(int myInt, string myString)
        {
            for(int a = 0; a<myInt; a++)
            {
                myString += myString;
            }
            return myString;
        }

        public static string ConvertIntToString(int myInt, string myString)
        {
            return myString + " " + myInt;
        }

        public static void EnvokeDelRegularMethod(Person p, int q, string w)
        {
            p.Fname += w;
            p.Lname += q.ToString();
        }
    }

}