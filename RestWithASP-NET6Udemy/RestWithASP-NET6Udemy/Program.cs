using RestWithASP_NET6Udemy.Services;
using RestWithASP_NET6Udemy.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Dependency injection
builder.Services.AddControllers();
builder.Services.AddScoped<IPersonService, PersonService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
