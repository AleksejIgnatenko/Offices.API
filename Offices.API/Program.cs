using MediatR;
using Microsoft.EntityFrameworkCore;
using Offices.Application.Commands.OfficeCommands.Create;
using Offices.Application.Commands.OfficeCommands.Delete;
using Offices.Application.Commands.OfficeCommands.Update;
using Offices.Application.Queries.OfficeQueries.GetAll;
using Offices.Application.Queries.OfficeQueries.GetById;
using Offices.Core.Models;
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

builder.Services.AddScoped<IRequestHandler<CreateOfficeCommand, OfficeEntity>, CreateOfficeCommandHandler>();
builder.Services.AddScoped<IRequestHandler<GetOfficeByIdQuery, OfficeEntity>, GetOfficeByIdQueryHandle>();
builder.Services.AddScoped<IRequestHandler<GetAllOfficesQuery, IEnumerable<OfficeEntity>>, GetAllOfficesQueryHandle>();
builder.Services.AddScoped<IRequestHandler<UpdateOfficeCommand, OfficeEntity>, UpdateOfficeCommandHandle>();
builder.Services.AddScoped<IRequestHandler<DeleteOfficeCommand>, DeleteOfficeCommandHandle>();

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
