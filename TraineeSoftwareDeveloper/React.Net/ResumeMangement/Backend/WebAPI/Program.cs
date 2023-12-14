using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using WebAPI.Core.AutoMapper;
using WebAPI.Core.Context;

var builder = WebApplication.CreateBuilder(args);

// DB Configuration
builder.Services.AddDbContext<ResumeDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("local"));
});

// AutoMapper Configuration
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

builder.Services.AddControllers().AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(opt =>
{
    opt.AllowAnyOrigin()
       .AllowAnyHeader()
       .AllowAnyMethod();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
