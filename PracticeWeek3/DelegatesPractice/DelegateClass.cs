using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DelegatesPractice.Program;

namespace DelegatesPractice
{
    public static class DelegateClass
    {
        public static string RegularMethod(RolosDelegateType x, int y, string z)
        {
            //RolosDel returns a string and has 2 parameters, a int, and a string
            return x(y, z);
        }

        public static void EnvokeDelRegularMethod(Person p, int x, string y, RolosDelegateType1 jumblies)
        {
            jumblies(p, x, y);
        }
    }
}