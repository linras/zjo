using System;
using Refactoring.Models;
using System.Collections.Generic;

namespace Refactoring.Repository
{
    public class DogRepository
    {
        private List<Dog> Dogs { get; set; }
        public DogRepository()
        {
            Dogs = new List<Dog>();
        }
        public IEnumerable<Dog> GetDogs()
        {
            return Dogs;
        }

        public Dog GetDog(int id)
        {
            Dog dog = new Dog();
            Dog returnedDog = new Dog();
            dog.Id = id;
            returnedDog = Dogs.Find(d => d.Id == id);
            if (returnedDog == null) return null;
            if (returnedDog.Amount == null) return null;

            return returnedDog;
        }

        public void SetDog(Dog dog)
        {
           Dogs.Add(dog);
        } 

        public decimal CountHowMuchYouMustSpendMoneyToBeHappy( decimal firsValue, decimal secondValue, decimal thirdValue) {
            decimal amount = CountDecimalValue(1, 2, 3,firsValue, secondValue, thirdValue);

            return amount;
        }

        public decimal CountHowMuchYouMustSpendMoneyToBeFine(decimal firsValue, decimal secondValue,decimal thirdValue)
        {
            decimal amount = CountDecimalValue(3, 2, 1,firsValue, secondValue, thirdValue);

            return amount;
        }

        public string getTitle(string title, string subtitle, string author)
        {
            string toBeReturned = "";
            string header = "";
            string extendedTitle = title + " " + subtitle;
            header = extendedTitle + " " + author + " ";
            toBeReturned += header;
            return toBeReturned;
        }

        public decimal CountDecimalValue(decimal a, decimal b, decimal c, decimal firsValue, decimal secondValue,
            decimal thirdValue)
        {
            decimal amount = 0;
            if (firsValue < 0 && secondValue < 0 && thirdValue < 0) return amount;
            decimal[] sorted = new[] { firsValue, secondValue, thirdValue };
            Array.Sort(sorted);

            amount = sorted[0] * a + sorted[1] * b + sorted[2] * c;
            return amount;
        }
    }
}
