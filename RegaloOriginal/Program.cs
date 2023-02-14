using ComuniDev.WebEFCore.API.Models;
using Microsoft.EntityFrameworkCore;
using RegaloOriginal.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Get connection String
var connectionString = builder.Configuration.GetConnectionString("DevConnection");
//Add dbcontext
builder
    .Services
    .AddDbContext<RegaloOriginalDbContext>
    (options => options.UseSqlServer(connectionString));

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
