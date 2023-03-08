using Microsoft.EntityFrameworkCore;
using VMSApi.Interfaces;
using VMSApi.Models;
using VMSApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

var AllowSpecificOrigins = "_allowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowSpecificOrigins,
        policy =>
        {
            policy.AllowAnyMethod().AllowAnyHeader();
        });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Set Database
var connectionString = builder.Configuration.GetConnectionString("DBLocal");
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));

// Set DI Mapping
builder.Services.AddScoped<IGuestRepository, GuestRepository>();

// Set automapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(AllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
