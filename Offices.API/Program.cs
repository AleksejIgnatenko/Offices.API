using MediatR;
using Microsoft.EntityFrameworkCore;
using Offices.API.Extensions;
using Offices.Application.Offices.Models;
using Offices.Application.Offices.UseCases.Create;
using Offices.Application.Offices.UseCases.Delete;
using Offices.Application.Offices.UseCases.GetAll;
using Offices.DataAccess.Context;
using Offices.DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<OfficesDbContext>(opt => opt.UseInMemoryDatabase("Offices"));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

builder.Services.AddCQRSHandlers();

builder.Services.AddScoped<IOfficeRepository, OfficeRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
