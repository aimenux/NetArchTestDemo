using System.Reflection;
using Api;
using Application.Abstractions;
using Domain.Models;
using Infrastructure;

namespace ArchitectureTests;

internal static class Constants
{
    public static readonly Assembly ApiAssembly = typeof(Startup).Assembly;
    public static readonly Assembly DomainAssembly = typeof(Product).Assembly;
    public static readonly Assembly ApplicationAssembly = typeof(IProductService).Assembly;
    public static readonly Assembly InfrastructureAssembly = typeof(ProductRepository).Assembly;
    public static readonly string ApiNamespace = ApiAssembly.GetName().Name;
    public static readonly string DomainNamespace = DomainAssembly.GetName().Name;
    public static readonly string ApplicationNamespace = ApplicationAssembly.GetName().Name;
    public static readonly string InfrastructureNamespace = InfrastructureAssembly.GetName().Name;
}