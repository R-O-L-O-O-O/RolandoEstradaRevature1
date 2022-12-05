
//Create a space at line 1 ^^, then r-click > refactor to add in the Main method adn namespace
//Create a delegate globally so that the class has access to it
//Create a class with methods that we can assign to that delegate
//Envoke the RegularMethod() with the delegate
using DelegatesPractice;

namespace DelegatesPractice
{
    public class Program
    {
        public delegate string RolosDelegateType(int x, string y);
        public delegate void RolosDelegateType1(Person p, int x, string y);
        public static void Main(string[] args)
        {
            RolosDelegateType mdt = MethodClass.AppendString;
            //string result = DelegateClass.RegularMethod(mdt, 5, "Rolo did it!");
            //Console.WriteLine(result);

            RolosDelegateType mdt1 = MethodClass.ConvertIntToString;
            string result1 = DelegateClass.RegularMethod(mdt, 5, "Rolo is awesome!");
            //Console.WriteLine(result1);

            //Create delegate so that I can assign some matching methods to it and multicast
            RolosDelegateType1 mdt2 = MethodClass.ChangePerson;
            mtd2 += MethodClass.ChangePerson2;

            Person p = new Person();

            DelegateClass.EnvokeDelRegularMethod(p, 100, "Kiriko", mdt2);
            Console.WriteLine($"The first name is =>{p.Fname} and the last name is => {p.Lname}");
        }

    }

}

