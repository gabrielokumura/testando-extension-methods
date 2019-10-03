using System;


namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dt = new DateTime(2019,10,03,16,10,45);

            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
