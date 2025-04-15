using FluentAssertions;
using NetArchTest.Rules;
using NUnit.Framework;

namespace ArchitectureTests;

public class ApplicationTests
{
    [Test]
    public void Should_Application_Not_Depends_On_Api()
    {
        var result = Types.InAssembly(Constants.ApplicationAssembly)
            .That()
            .ResideInNamespace(Constants.ApplicationNamespace)
            .ShouldNot()
            .HaveDependencyOn(Constants.ApiNamespace)
            .GetResult();
        
        result.IsSuccessful.Should().BeTrue();
    }
    
    [Test]
    public void Should_Application_Not_Depends_On_Infrastructure()
    {
        var result = Types.InAssembly(Constants.ApplicationAssembly)
            .That()
            .ResideInNamespace(Constants.ApplicationNamespace)
            .ShouldNot()
            .HaveDependencyOn(Constants.InfrastructureNamespace)
            .GetResult();
        
        result.IsSuccessful.Should().BeTrue();
    }
    
    [Test]
    public void Should_Application_Depends_On_Domain()
    {
        var result = Types.InAssembly(Constants.ApplicationAssembly)
            .That()
            .ResideInNamespace(Constants.ApplicationNamespace)
            .Should()
            .HaveDependencyOn(Constants.DomainNamespace)
            .GetResult();
        
        result.IsSuccessful.Should().BeTrue();
    }
}