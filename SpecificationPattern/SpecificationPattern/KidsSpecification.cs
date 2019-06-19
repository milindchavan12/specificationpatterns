using System;
using System.Linq.Expressions;

namespace SpecificationPattern
{
    public sealed class KidsSpecification : Specification<Person>
    {
        readonly int kidsAgeBar = 18;

        public override Expression<Func<Person, bool>> ToExpression()
        {
            return person => person.Age < kidsAgeBar;
        }
    }
}
