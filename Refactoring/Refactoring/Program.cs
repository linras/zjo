using Refactoring.Models;
using Refactoring.Repository;
using System;

namespace Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            DogRepository repo = new DogRepository();
            repo.SetDog(new Dog( 1, (decimal)12.4, (decimal)134.5));
            repo.SetDog(new Dog(2));
            repo.GetDogs();
            repo.GetDog(1);
            string s1 = repo.CountHowMuchYouMustSpendMoneyToBeHappy((decimal)12.4, 
                (decimal)134.5, (decimal)12.4, 
                "title", "subtitle", "author");
            string s2 = repo.CountHowMuchYouMustSpendMoneyToBeFine((decimal)12.4, 
                (decimal)134.5, (decimal)12.4,  
                "title", "subtitle", "author");
            Console.WriteLine(s1 +" vs "+ s2);
            Console.ReadKey();
        }
    }
}
