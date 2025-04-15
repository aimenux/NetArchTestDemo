using FluentAssertions;
using NetArchTest.Rules;
using NUnit.Framework;

namespace ArchitectureTests;

public class DomainTests
{
    [Test]
    public void Should_Domain_Not_Depends_On_Api()
    {
        var result = Types.InAssembly(Constants.DomainAssembly)
            .That()
            .ResideInNamespace(Constants.DomainNamespace)
            .ShouldNot()
            .HaveDependencyOn(Constants.ApiNamespace)
            .GetResult();
        
        result.IsSuccessful.Should().BeTrue();
    }
    
    [Test]
    public void Should_Domain_Not_Depends_On_Application()
    {
        var result = Types.InAssembly(Constants.DomainAssembly)
            .That()
            .ResideInNamespace(Constants.DomainNamespace)
            .ShouldNot()
            .HaveDependencyOn(Constants.ApplicationNamespace)
            .GetResult();
        
        result.IsSuccessful.Should().BeTrue();
    }
    
    [Test]
    public void Should_Domain_Not_Depends_On_Infrastructure()
    {
        var result = Types.InAssembly(Constants.DomainAssembly)
            .That()
            .ResideInNamespace(Constants.DomainNamespace)
            .ShouldNot()
            .HaveDependencyOn(Constants.InfrastructureNamespace)
            .GetResult();
        
        result.IsSuccessful.Should().BeTrue();
    }
}