//global using advent_of_code_2023.Models;
global using advent_of_code_2023.Services.DayOne;
global using advent_of_code_2023.Services.DayFour;
global using advent_of_code_2023.Services.DayTwo;
global using advent_of_code_2023.Services.DayThree;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IDayOneService, DayOneService>();
builder.Services.AddScoped<IDayFourService, DayFourService>();
builder.Services.AddScoped<IDayTwoService, DayTwoService>();
builder.Services.AddScoped<IDayThreeService, DayThreeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();


app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
