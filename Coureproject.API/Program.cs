using Courseprject.Common.Interfaces;
using Courseprject.Common.Model;
using Courseproject.Business;
using Courseproject.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
DIConfiguration.RegisterService(builder.Services);
builder.Services.AddDbContext<ApplicationDbContext>();
builder.Services.AddScoped<IGenericRepository<Address>, GenericRepository<Address>>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using(var scope = app.Services.CreateScope())
{
    var dbContext =  scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.EnsureCreated();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
