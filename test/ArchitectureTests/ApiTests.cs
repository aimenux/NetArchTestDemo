using FluentAssertions;
using NetArchTest.Rules;
using NUnit.Framework;

namespace ArchitectureTests;

public class ApiTests
{
    [Test]
    public void Should_Api_Controllers_Not_Depends_On_Infrastructure()
    {
        var result = Types.InAssembly(Constants.ApiAssembly)
            .That()
            .HaveNameEndingWith("Controller")
            .ShouldNot()
            .HaveDependencyOnAny(Constants.InfrastructureNamespace)
            .GetResult();
        
        result.IsSuccessful.Should().BeTrue();
    }
}