using Microsoft.EntityFrameworkCore;
using IndustrialManager.Data;

var builder = WebApplication.CreateBuilder(args);

// SERVIÇOS
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => {
    options.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=industrial.db"));

var app = builder.Build();

// PIPELINE (A ordem aqui importa muito!)
app.UseCors(); 
app.UseHttpsRedirection();
app.MapControllers();

app.Run();