﻿using HexagonalArchitecture.Application.SeedWork;
using System;

namespace HexagonalArchitecture.Application.Aggregates.EmployeeAggregate
{
    public class Salary : IValueObject
    {
        public decimal Amount { get; private set; }

        private Salary(decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Value must be greater than 0.");
            }

            Amount = amount;
        }

        public static implicit operator Salary(decimal amount)
        {
            return new Salary(amount);
        }

        public static implicit operator decimal(Salary salary)
        {
            return salary.Amount;
        }
    }
}
