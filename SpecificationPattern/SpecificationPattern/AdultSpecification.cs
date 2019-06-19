using System;
using System.Linq.Expressions;

namespace SpecificationPattern
{
    public sealed class AdultSpecification : Specification<Person>
    {
        readonly int adultAgeBar = 18;

        public override Expression<Func<Person, bool>> ToExpression()
        {
            return person => person.Age > adultAgeBar;
        }
    }
}
