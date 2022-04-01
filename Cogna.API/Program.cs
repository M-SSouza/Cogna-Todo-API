using Cogna.Application.Services.Todos;
using Cogna.Core.Interfaces.Repositories;
using Cogna.Infrastructure.Persistence;
using Cogna.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<CognaDbContext>(options =>
    options.UseSqlServer(connectionString)
);

builder.Services.AddScoped<ITodosRepository, TodosRepository>();
builder.Services.AddScoped<ITodosService, TodosService>();

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
