using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Bob"; //const means the variable can't chnage.  need to assign value to it when creating it
            Console.WriteLine(name);

            float number = 2.5f;  //need to include the 'f' at end of value
            decimal decNumber = 2.5m; //need to include the 'm' at end of value 
        }
    }
}
