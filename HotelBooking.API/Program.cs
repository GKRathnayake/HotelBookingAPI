using AutoMapper;
using HotelBooking.Application.Mapper;
using HotelBooking.Application.Services;
using HotelBooking.Application.Services.Interfaces;
using HotelBooking.Infrastructure;
using HotelBooking.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var connectionString = builder.Configuration.GetConnectionString("Hotel");
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

// Auto Mapper Configurations
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

//
//  Register services
//
builder.Services.AddScoped<IHotelService, HotelService>();
//.AddScoped<IOrderService, OrderService>()
//.AddScoped<IProductService, ProductService>()
//.AddScoped<IInvoiceService, InvoiceService>();

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
