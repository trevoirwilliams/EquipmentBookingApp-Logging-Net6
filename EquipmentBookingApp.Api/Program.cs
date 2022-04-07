using EquipmentBookingApp.Core;
using EquipmentBookingApp.Domain;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var folder = Environment.SpecialFolder.LocalApplicationData;
var folderPath = Environment.GetFolderPath(folder);
var dbPath = Path.Join(folderPath, "equipment.db");
var conn = new SqliteConnection($"Data Source={dbPath}");
builder.Services.AddDbContext<EquipmentBookingDbContext>(opt => opt.UseSqlite(conn));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IEquipmentBookingService, EquipmentBookingService>();
builder.Services.AddScoped<IEquipmentBookingRepository, EquipmentBookingRepository>();


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
