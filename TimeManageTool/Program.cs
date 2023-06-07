using System.Configuration;
using AutoMapper;
using TimeManageTool.Data;
using Microsoft.EntityFrameworkCore;
using TimeManageTool.Data.Repositories;
using TimeManageTool.DTOS;
using TimeManageTool.Models;
using TimeManageTool.Profiles;


var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
    );

// Add services to the container.

builder.Services.AddDbContext<TimeManageContext>(options => options.UseMySQL(connection));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new ActivityProfile());
    mc.AddProfile(new CustomerProfile());
    mc.AddProfile(new OrganisationProfile());
    mc.AddProfile(new LocationProfile());
    mc.AddProfile(new ProductProfile());
    mc.AddProfile(new ProductUsedProfile());
    mc.AddProfile(new TimeProfile());
    mc.AddProfile(new UserProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

//builder.Services.AddAutoMapper(typeof(Program));

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

