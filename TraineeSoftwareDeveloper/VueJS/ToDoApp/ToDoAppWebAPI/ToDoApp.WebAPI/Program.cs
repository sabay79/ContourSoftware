using Microsoft.EntityFrameworkCore;
using ToDoApp.WebAPI.Data;
using ToDoApp.WebAPI.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure Entity Framework - Db Context
builder.Services.AddScoped<DbContext, ToDoDbContext>();
builder.Services.AddDbContext<ToDoDbContext>(opt => opt
                .UseSqlServer(builder.Configuration.GetConnectionString("DbConnection")));

builder.Services.AddScoped<NoteBusinessServices, NoteBusinessServices>();

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
