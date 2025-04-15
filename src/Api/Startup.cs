using Api.Mappers;
using Application.Abstractions;
using Application.Services;
using Infrastructure;

namespace Api;

public class Startup
{
    public void ConfigureServices(WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddRouting(options => options.LowercaseUrls = true);
        builder.Services.AddSingleton<IProductMapper, ProductMapper>();
        builder.Services.AddSingleton<IProductService, ProductService>();
        builder.Services.AddSingleton<IProductRepository, ProductRepository>();
    }

    public void Configure(WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(options => options.DisplayRequestDuration());
        }
        
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
    }
}