using System.Reflection;
using Api;
using Api.Controllers;
using Api.Mappers;
using Api.Payloads;
using Domain.Models;
using FluentAssertions;
using Infrastructure;
using NetArchTest.Rules;
using NUnit.Framework;

namespace UnitTests
{
    public class ArchitectureTests
    {
        private static string ApiNamespace => ApiAssembly.GetName().Name;
        private static string DomainNamespace => DomainAssembly.GetName().Name;
        private static string InfrastructureNamespace => InfrastructureAssembly.GetName().Name;

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
        [Ignore("Issue https://github.com/BenMorris/NetArchTest/issues/40")]
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
        public void Should_Api_Depends_On_Domain()
        {
            var excludedNames = new[]
            {
                nameof(Program),
                nameof(ProductDto),
                nameof(IProductMapper)
            };

            Types.InAssembly(ApiAssembly)
                .That().ResideInNamespace(ApiNamespace)
                .And().DoNotHaveNames(excludedNames)
                .Should().HaveDependencyOn(DomainNamespace)
                .GetResult().IsSuccessful
                .Should().BeTrue();
        }

        [Test]
        public void Should_Api_Depends_On_Infrastructure()
        {
            var excludedNames = new[]
            {
                nameof(Program),
                nameof(ProductDto),
                nameof(ProductMapper),
                nameof(IProductMapper),
                nameof(ProductController)
            };

            Types.InAssembly(ApiAssembly)
                .That().ResideInNamespace(ApiNamespace)
                .And().DoNotHaveNames(excludedNames)
                .Should().HaveDependencyOn(InfrastructureNamespace)
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