using Microsoft.EntityFrameworkCore;
using Payment.Business.Interfaces;
using Payment.Business.Services;
using Payment.Data;
using Payment.Data.Interfaces;
using Payment.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DB Context Configuration
builder.Services.AddDbContext<PaymentDetailContext>(options => options
                .UseSqlServer(builder.Configuration.GetConnectionString("DbConnection")));

// Repository Configuration
builder.Services.AddScoped<IPaymentDetailRepository, PaymentDetailRepository>();

// Business Service Configuration
builder.Services.AddScoped<IPaymentDetailService, PaymentDetailService>();

// AutoMapper Configuration
builder.Services.AddAutoMapper(typeof(MapperConfig));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
