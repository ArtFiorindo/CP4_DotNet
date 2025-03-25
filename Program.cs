using BrinquedosApi.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<BrinquedosContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("OracleDbConnection")));

// Configura o Swagger
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// O Swagger é habilitado em todos os ambientes, não só em desenvolvimento
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    // Configura o endpoint do Swagger e a porta
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Brinquedos API V1");
    c.RoutePrefix = string.Empty; // Isso faz o Swagger rodar diretamente em http://localhost:5000
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();