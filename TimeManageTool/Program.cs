using System.Configuration;
using TimeManageTool.Data;
using Microsoft.EntityFrameworkCore;
using TimeManageTool.Data.Repositories;
using TimeManageTool.Models;


var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.

builder.Services.AddDbContext<TimeManageContext>(options => options.UseMySQL(connection));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<ActivityRepository>();
builder.Services.AddScoped<CustomerRepository>();
builder.Services.AddScoped<LocationRepository>();
builder.Services.AddScoped<OrganisationRepository>();
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<ProductUsedRepository>();
builder.Services.AddScoped<TimeRepository>();
builder.Services.AddScoped<UserRepository>();

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

