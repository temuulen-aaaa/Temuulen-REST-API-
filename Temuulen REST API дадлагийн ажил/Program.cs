using Microsoft.EntityFrameworkCore;
using Temuulen_REST_API_дадлагийн_ажил.Data;

var builder = WebApplication.CreateBuilder(args);

// ------------ Services ------------
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();   // AddOpenApi-? SwaggerGen ?????? ???????
// -----------------------------------

var app = builder.Build();

// ------------ Pipeline -------------
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
// -----------------------------------

app.Run();
