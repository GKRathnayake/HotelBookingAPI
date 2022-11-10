using AutoMapper;
using HotelBooking.Application.Mapper;
using HotelBooking.Application.Services;
using HotelBooking.Application.Services.Interfaces;
using HotelBooking.Infrastructure;
using HotelBooking.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//
//  Add services to the container.
//
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//
//  Fetch connection string from configuration files and introduce DbContext.
//
var connectionString = builder.Configuration.GetConnectionString("Hotel");
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));
//
//  Register UoW (for repository patter with EF.Core).
//
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
//
// Configure Auto Mapper and introduce Auto Mapper for DI.
//
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
//
//  Register services for DI
//
builder.Services.AddScoped<IHotelService, HotelService>()
                .AddScoped<IBookingService, BookingService>();

var app = builder.Build();
//
//  SConfigure the HTTP request pipeline.
//
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();