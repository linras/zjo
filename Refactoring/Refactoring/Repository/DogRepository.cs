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
            decimal thirdValue, decimal forthValue, string title, string subtitle, string author) {
            string toBeReturned = "";
            decimal amount = 0;
            if (firsValue >= 0)
            {
                if (secondValue >= 0)
                {
                    if(thirdValue >= 0)
                    {
                        if(forthValue >= 0)
                        {
                            string fullTitle = title + " " + subtitle;
                            string fullHeader = fullTitle + " " + author;
                            if (firsValue > secondValue && firsValue > thirdValue)
                            {
                                if(secondValue > thirdValue)
                                {
                                    amount = 3 * firsValue + 2 * secondValue + thirdValue;
                                }
                                else amount = 3 * firsValue + 2 * thirdValue +  secondValue;

                            }
                            if (secondValue > thirdValue && secondValue > firsValue)
                            {
                                if (thirdValue > firsValue)
                                {
                                    amount = 3 * secondValue + 2 * thirdValue + firsValue;
                                }
                                else amount = 3 * secondValue + 2 * firsValue + thirdValue;
                            }
                            if (thirdValue > firsValue && thirdValue > secondValue)
                            {
                                if (firsValue > secondValue)
                                {
                                    amount = 3 * thirdValue + 2 * firsValue + secondValue;
                                }
                                else amount = 3 * thirdValue + 2 * secondValue + firsValue;
                            }
                        }
                    }
                }
            }
            return toBeReturned + " "+ amount;
        }

        public string CountHowMuchYouMustSpendMoneyToBeFine(decimal firsValue, decimal secondValue,
            decimal thirdValue, decimal forthValue, string title, string subtitle, string author)
        {
            string toBeReturned = "";
            decimal amount = 0;
            if (firsValue >= 0)
            {
                if (secondValue >= 0)
                {
                    if(thirdValue >= 0)
                    {
                        if(forthValue >= 0)
                        {
                            string fullTitle = title + " " + subtitle;
                            string fullHeader = fullTitle + " " + author;
                            toBeReturned += fullHeader;
                            if (firsValue > secondValue && firsValue > thirdValue)
                            {
                                if(secondValue > thirdValue)
                                {
                                    amount = 3 * thirdValue + 2 * secondValue + firsValue;
                                }
                                else amount = 3 * secondValue + 2 * thirdValue + firsValue;

                            }
                            if (secondValue > thirdValue && secondValue > firsValue)
                            {
                                if (thirdValue > firsValue)
                                {
                                    amount = 3 * firsValue + 2 * thirdValue + secondValue;
                                }
                                else amount = 3 * thirdValue + 2 * firsValue + secondValue;
                            }
                            if (thirdValue > firsValue && thirdValue > secondValue)
                            {
                                if (firsValue > secondValue)
                                {
                                    amount = 3 * secondValue + 2 * firsValue + thirdValue;
                                }
                                else amount = 3 * firsValue + 2 * secondValue + thirdValue;
                            }
                        }
                    }
                }
            }
            return toBeReturned + " "+ amount;
        }
    }
}
