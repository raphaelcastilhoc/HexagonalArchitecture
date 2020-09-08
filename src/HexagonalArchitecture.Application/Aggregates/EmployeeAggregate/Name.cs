using HexagonalArchitecture.Application.SeedWork;

namespace HexagonalArchitecture.Application.Aggregates.EmployeeAggregate
{
    public class Name : IValueObject
    {
        public Name(string fistName, string lastName)
        {
            FistName = fistName;
            LastName = lastName;
        }

        public string FistName { get; private set; }

        public string LastName { get; private set; }

        public static implicit operator string(Name name)
        {
            return $"{name.FistName} {name.LastName}";
        }
    }
}
