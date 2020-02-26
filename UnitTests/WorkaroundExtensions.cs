using System;
using System.Linq;
using NetArchTest.Rules;

namespace UnitTests
{
    public static class WorkaroundExtensions
    {
        private static readonly string InvalidName = Guid.NewGuid().ToString();

        public static PredicateList DoNotHaveNames(this Predicates predicates, params string[] excludedNames)
        {
            var predicateList = predicates.DoNotHaveName(InvalidName);
            return excludedNames == null || !excludedNames.Any()
                ? predicateList
                : excludedNames.Aggregate(predicateList, (current, name) => current.And().DoNotHaveName(name));
        }
    }
}
