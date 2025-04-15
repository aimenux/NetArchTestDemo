using FluentAssertions;
using NetArchTest.Rules;
using NUnit.Framework;

namespace ArchitectureTests;

public class InfrastructureTests
{
    [Test]
    public void Should_Infrastructure_Not_Depends_On_Api()
    {
        var result = Types.InAssembly(Constants.InfrastructureAssembly)
            .That()
            .ResideInNamespace(Constants.InfrastructureNamespace)
            .ShouldNot()
            .HaveDependencyOn(Constants.ApiNamespace)
            .GetResult();
        
        result.IsSuccessful.Should().BeTrue();
    }
    
    [Test]
    public void Should_Infrastructure_Depends_On_Application()
    {
        var result = Types.InAssembly(Constants.InfrastructureAssembly)
            .That()
            .ResideInNamespace(Constants.InfrastructureNamespace)
            .Should()
            .HaveDependencyOn(Constants.ApplicationNamespace)
            .GetResult();
        
        result.IsSuccessful.Should().BeTrue();
    }
    
    [Test]
    public void Should_Infrastructure_Depends_On_Domain()
    {
        var result = Types.InAssembly(Constants.InfrastructureAssembly)
            .That()
            .ResideInNamespace(Constants.InfrastructureNamespace)
            .Should()
            .HaveDependencyOn(Constants.DomainNamespace)
            .GetResult();
        
        result.IsSuccessful.Should().BeTrue();
    }
}