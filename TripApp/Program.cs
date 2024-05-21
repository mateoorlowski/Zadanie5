using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using TripApp.Context;
using Zadanie7.Repositories;
using Zadanie7.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MasterContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<MasterContext, MasterContext>();
builder.Services.AddTransient<ITripsRepository, TripsRepository>();
builder.Services.AddTransient<IClientRepository, ClientRepository>();
builder.Services.AddTransient<ITripsService, TripsService>();
builder.Services.AddTransient<IClientService, ClientService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    options =>
    {
        options.MapType<DateOnly>(() => new OpenApiSchema
        {
            Type = "string",
            Format = "date",
            Example = new OpenApiString("2024-01-07")
        });
    });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();