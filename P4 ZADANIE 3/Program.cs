using System;

namespace P4_ZADANIE_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var myContext = new MyDBContext();
            myContext.Database.EnsureCreated();

            myContext.Urzyszkodnicy.Add(new MyUsers() {Name = "Gienek", RegistrationDate = DateTime.Now, Description = "I nastała światłość... albo ciemność..." });
            myContext.SaveChanges();

        }
    }
}
