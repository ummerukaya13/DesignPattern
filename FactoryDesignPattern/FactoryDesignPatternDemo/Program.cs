using FactoryDesignPatternDemo.Enums;
using FactoryDesignPatternDemo.Factories;
using FactoryDesignPatternDemo.Services;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.MapType<StreamType>(() => new OpenApiSchema
    {
        Type = "string",
        Enum = new List<IOpenApiAny>
        {
            new OpenApiString("Netflix"),
            new OpenApiString("Amazon")
        }
    });
});

builder.Services.AddScoped<StreamFactory>();
builder.Services.AddScoped<NetflixStreamService>()
    .AddScoped<IStreamService, NetflixStreamService>(s => s.GetService<NetflixStreamService>());
builder.Services.AddScoped<AmazonStreamService>()
    .AddScoped<IStreamService, AmazonStreamService>(s => s.GetService<AmazonStreamService>());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
