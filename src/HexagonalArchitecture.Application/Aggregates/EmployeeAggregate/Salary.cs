using HexagonalArchitecture.Application.SeedWork;
using System;

namespace HexagonalArchitecture.Application.Aggregates.EmployeeAggregate
{
    public class Salary : IValueObject
    {
        private decimal _amount;

        private Salary(decimal amount)
        {
            _amount = amount;
        }

        public static implicit operator Salary(decimal amount)
        {
            if(amount <= 0)
            {
                throw new Exception("Value must be greater than 0.");
            }

            return new Salary(amount);
        }

        public static implicit operator decimal(Salary salary)
        {
            return salary._amount;
        }
    }
}
