using System;
using Refactoring.Models;
using System.Collections.Generic;

namespace Refactoring.Repository
{
    public class DogRepository
    {
        private List<Dog> Dogs { get;}
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
            var dog = Dogs.Find(d => d.Id == id);

            return dog?.Amount != null ? dog : null;
        }

        public void SetDog(Dog dog)
        {
           Dogs.Add(dog);
        } 

        public decimal CountHowMuchYouMustSpendMoneyToBeHappy( decimal firsValue, decimal secondValue, decimal thirdValue) 
        {
            return CountDecimalValue(1, 2, 3, firsValue, secondValue, thirdValue);
        }

        public decimal CountHowMuchYouMustSpendMoneyToBeFine(decimal firsValue, decimal secondValue,decimal thirdValue)
        {
            return CountDecimalValue(3, 2, 1, firsValue, secondValue, thirdValue);
        }

        public string GetTitle(string title, string subtitle, string author)
        {
            return title + " " + subtitle + " " + author+ " ";
        }

        public decimal CountDecimalValue(decimal a, decimal b, decimal c, decimal firsValue, decimal secondValue,
            decimal thirdValue)
        {
            if (firsValue < 0 && secondValue < 0 && thirdValue < 0) return 0;

            decimal[] sorted = { firsValue, secondValue, thirdValue };
            Array.Sort(sorted);

            return sorted[0] * a + sorted[1] * b + sorted[2] * c;
        }
    }
}
