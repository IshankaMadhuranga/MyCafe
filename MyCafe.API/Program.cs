using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyCafe.DataAccess;
using MyCafe.Services.Employees;
using MyCafe.Services.Cafes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<ICafeRepository, CafeSevice>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeService>();
//builder.Services.AddDbContext<MyCafeDbContext>(options =>
//        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
//);

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
