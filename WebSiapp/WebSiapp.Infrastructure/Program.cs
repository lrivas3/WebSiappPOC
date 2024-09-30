using System.Reflection;
using WebSiapp.Infrastructure.Common.Errors;
using WebSiapp.Infrastructure.DrivenAdapters.Database.Configuration;
using WebSiapp.Infrastructure.DrivingAdapters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

ConfigurationManager configuration = builder.Configuration;
builder.Services.Configure<AppSettings>(configuration.GetSection(nameof(AppSettings)));
AppSettings appSettings = new();
configuration.GetSection(nameof(AppSettings)).Bind(appSettings);

builder.Services.AddControllers();
builder.Services.AddSingleton<ProblemDetailsFactory, WebSiappCustomProblemDetailsFactory>(); // TODO: Pasar a presentation
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

app.UseExceptionHandler("/error");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
