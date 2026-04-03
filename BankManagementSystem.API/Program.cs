using BankManagementSystem.Application.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// 1. Registrar servicios de Application para inyección de dependencias
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<LoanService>();
builder.Services.AddScoped<AccountService>();

// 2. Registrar controllers y Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 3. Configurar el pipeline de HTTP (Middleware)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bank API V1");
        c.RoutePrefix = string.Empty; // Swagger se abrirá en la raíz (http://localhost:XXXX/)
    });
}

app.UseHttpsRedirection();

// Importante: Si usas autenticación, debe ir antes de Authorization
// app.UseAuthentication(); 
app.UseAuthorization();

app.MapControllers();

app.Run();