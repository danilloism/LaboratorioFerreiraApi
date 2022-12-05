using Data.Context;
using Enums;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Npgsql.NameTranslation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var dataSourceBuilder = new NpgsqlDataSourceBuilder(
    "Server=localhost,5432;Database=lab;User ID=postgres;Password=dnn");
dataSourceBuilder.MapEnum<CategoriasEnum>(nameTranslator: new NpgsqlSnakeCaseNameTranslator());
var dataSource = dataSourceBuilder.Build();
builder.Services.AddDbContext<LabDbContext>(s => s.UseNpgsql(dataSource));
builder.Services.AddControllers();
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