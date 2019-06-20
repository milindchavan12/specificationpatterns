using System;
using System.Linq.Expressions;

namespace SpecificationPattern
{
    public sealed class ToddlerSpecification : Specification<Person>
    {
        readonly int toddlerAgeBar = 4;

        public override Expression<Func<Person, bool>> ToExpression()
        {
            return person => person.Age < toddlerAgeBar;
        }
    }
}
