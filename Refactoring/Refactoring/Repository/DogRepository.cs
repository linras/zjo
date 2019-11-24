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

        public string CountHowMuchYouMustSpendMoneyToBeHappy( decimal firsValue, decimal secondValue, 
            decimal thirdValue, string title, string subtitle, string author) {
            string toBeReturned = "";
            decimal amount = CountDecimalValue(1, 2, 3,
                firsValue, secondValue, thirdValue);

            return toBeReturned + " " + amount;
        }

        public string CountHowMuchYouMustSpendMoneyToBeFine(decimal firsValue, decimal secondValue,
            decimal thirdValue, string title, string subtitle, string author)
        {
            string toBeReturned = "";
            decimal amount = CountDecimalValue(3, 2, 1,
                firsValue, secondValue, thirdValue);

            return toBeReturned + " "+ amount;
        }

        public decimal CountDecimalValue(decimal a, decimal b, decimal c, decimal firsValue, decimal secondValue,
            decimal thirdValue)
        {
            decimal amount = 0;
            if (firsValue >= 0)
            {
                if (secondValue >= 0)
                {
                    if (thirdValue >= 0)
                    {
                        if (firsValue > secondValue && firsValue > thirdValue)
                        {
                            if (secondValue > thirdValue)
                            {
                                amount = a * thirdValue + b * secondValue + c * firsValue;
                            }
                            else amount = a * secondValue + b * thirdValue + c * firsValue;

                        }
                        if (secondValue > thirdValue && secondValue > firsValue)
                        {
                            if (thirdValue > firsValue)
                            {
                                amount = a * firsValue + b * thirdValue + c * secondValue;
                            }
                            else amount = a * thirdValue + b * firsValue + c * secondValue;
                        }
                        if (thirdValue > firsValue && thirdValue > secondValue)
                        {
                            if (firsValue > secondValue)
                            {
                                amount = a * secondValue + b * firsValue + c * thirdValue;
                            }
                            else amount = a * firsValue + b * secondValue + c * thirdValue;
                        }
                    }
                }
            }
            return amount;
        }
    }
}
