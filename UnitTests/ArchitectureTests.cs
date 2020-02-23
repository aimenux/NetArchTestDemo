using System.Reflection;
using Api;
using Domain.Models;
using FluentAssertions;
using Infrastructure;
using NetArchTest.Rules;
using NUnit.Framework;

namespace UnitTests
{
    public class ArchitectureTests
    {
        private const string ApiNamespace = "Api";
        private const string DomainNamespace = "Domain";
        private const string InfrastructureNamespace = "Infrastructure";
        private static readonly Assembly ApiAssembly = typeof(Startup).Assembly;
        private static readonly Assembly DomainAssembly = typeof(Product).Assembly;
        private static readonly Assembly InfrastructureAssembly = typeof(ProductRepository).Assembly;

        [Test]
        public void Should_Domain_Not_Depends_On_Api()
        {
            Types.InAssembly(DomainAssembly)
                .That().ResideInNamespace(DomainNamespace)
                .ShouldNot().HaveDependencyOn(ApiNamespace)
                .GetResult().IsSuccessful
                .Should().BeTrue();
        }

        [Test]
        public void Should_Domain_Not_Depends_On_Infrastructure()
        {
            Types.InAssembly(DomainAssembly)
                .That().ResideInNamespace(DomainNamespace)
                .ShouldNot().HaveDependencyOn(InfrastructureNamespace)
                .GetResult().IsSuccessful
                .Should().BeTrue();
        }

        [Test]
        [Ignore("Not working as expected")]
        public void Should_Api_Depends_On_Domain_And_Infrastructure()
        {
            Types.InAssembly(ApiAssembly)
                .That().ResideInNamespace(ApiNamespace)
                .Should().HaveDependencyOn(DomainNamespace)
                .And().HaveDependencyOn(InfrastructureNamespace)
                .GetResult().IsSuccessful
                .Should().BeTrue();
        }

        [Test]
        public void Should_Infrastructure_Depends_On_Domain()
        {
            Types.InAssembly(InfrastructureAssembly)
                .That().ResideInNamespace(InfrastructureNamespace)
                .Should().HaveDependencyOn(DomainNamespace)
                .GetResult().IsSuccessful
                .Should().BeTrue();
        }
    }
}