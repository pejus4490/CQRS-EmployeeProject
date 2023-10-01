using Employee.IoC.Configuration;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.MapCore(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("V1",
        new OpenApiInfo
        {
            Title = "Employee",
            Version = "v1",
            Description = "This is a Employee Project to see how documentation can easily be generated" + "for ASP.NET Core Web APIs using Swagger and ReDoc.",
            Contact = new OpenApiContact
            {
                Name = "Pejus Kanti Sazzon",
                Email = "pejus4490@gmail.com"
            }
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

//Add it
    app.UseSwaggerUI( options =>
    options.SwaggerEndpoint("/swagger/V1/swagger.json","Demo Documentation v1"));

    app.UseReDoc(options =>
    {
        options.DocumentTitle = "Demo Documentation";
        options.SpecUrl = "/swagger/V1/swagger.json";
    });
    //
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
