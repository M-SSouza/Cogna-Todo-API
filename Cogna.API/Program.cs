using Cogna.Application.Services.Todos;
using Cogna.Core.Interfaces.Repositories;
using Cogna.Infrastructure.Persistence;
using Cogna.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

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
builder.Services.AddSwaggerGen(x =>
{
    x.SwaggerDoc(
    "v1", new OpenApiInfo
    {
        Title = "Cogna API",
        Version = "v1",
        Contact = new OpenApiContact
        {
            Name = "Matheus .S Souza",
            Email = "matheusdasilvasouza20@gmail.com",
            Url = new Uri("https://www.linkedin.com/in/mdassouza/")
        }
    });

    string xmlFile = "Cogna.API.xml";
    string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

    x.IncludeXmlComments(xmlPath);
});

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
