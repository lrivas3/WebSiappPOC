using System.Reflection;
using Infrastructure.DrivenAdapters.Database.Configuration;
using Infrastructure.DrivingAdapters;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

ConfigurationManager configuration = builder.Configuration;
builder.Services.Configure<AppSettings>(configuration.GetSection(nameof(AppSettings)));
AppSettings appSettings = new();
configuration.GetSection(nameof(AppSettings)).Bind(appSettings);

builder.Services.AddControllers();

builder.Services.AddUseCases();
builder.Services.AddAutoMapper(Assembly.Load(typeof(Program).Assembly.GetName().Name!));
builder.Services.AddPersistance(appSettings.DatabaseConnection);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
