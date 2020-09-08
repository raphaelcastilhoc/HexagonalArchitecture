using HexagonalArchitecture.Application.SeedWork;
using System;

namespace HexagonalArchitecture.Application.Aggregates.EmployeeAggregate
{
    public class Employee : Entity, IAggregateRoot
    {
        public Employee(string firstName, string lastName, decimal salary)
        {
            Name = new Name(firstName, lastName);
            Salary = salary;
        }

        public Name Name { get; private set; }

        public Salary Salary { get; private set; }

        public void RaiseSalary(decimal salary)
        {
            if (salary <= Salary)
            {
                throw new InvalidOperationException("Salary must be greater than current salary");
            }

            Salary = salary;
        }
    }
}
