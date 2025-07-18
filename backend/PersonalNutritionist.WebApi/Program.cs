using PersonalNutritionist.Domain.Interfaces.Repositories;
using PersonalNutritionist.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
builder.Services.AddScoped<IActivityInfoRepository, ActivityInfoRepository>();
builder.Services.AddScoped<IGoalsRepository, GoalsRepository>();
builder.Services.AddScoped<ILifestyleRepository, LifestyleRepository>();
builder.Services.AddScoped<ILoginPasswordAuthRepository, LoginPasswordAuthRepository>();
builder.Services.AddScoped<IMedicalInfoRepository, MedicalInfoRepository>();
builder.Services.AddScoped<INutritionHabitsRepository, NutritionHabitsRepository>();
builder.Services.AddScoped<IPersonCardRepository, PersonCardRepository>();
builder.Services.AddScoped<IPhysicalParametersRepository, PhysicalParametersRepository>();
builder.Services.AddScoped<ITelegramAuthRepository, TelegramAuthRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
// builder.Services.AddScoped<>();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
