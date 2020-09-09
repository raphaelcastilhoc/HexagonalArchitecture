using HexagonalArchitecture.Application.SeedWork;

namespace HexagonalArchitecture.Application.Aggregates.EmployeeAggregate
{
    public class Name : IValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public static implicit operator string(Name name)
        {
            return $"{name.FirstName} {name.LastName}";
        }
    }
}
