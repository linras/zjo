using System;

namespace Refactoring.Models
{
    public class Dog
    {
        public Dog() { }

        public Dog(int id)
        {
            Id = id;
        }

        public Dog(int id, decimal? amount, decimal? otherAmount) : this(id)
        {
            Amount = amount;
            OtherAmount = otherAmount;
        }

        public Dog(int id, int? years, decimal? amount, decimal? otherAmount, DateTime dateOfBirth, DateTime dateOfLastVaccination, string name, string race)
        {
            Id = id;
            Years = years;
            Amount = amount;
            OtherAmount = otherAmount;
            DateOfBirth = dateOfBirth;
            DateOfLastVaccination = dateOfLastVaccination;
            Name = name;
            Race = race;
        }

        public int Id { get; set; }
        public int? Years { get; set; }
        public decimal? Amount { get; set; }
        public decimal? OtherAmount { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfLastVaccination { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
    }
}
