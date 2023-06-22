using MaSurvey.Domain.Entities;
using MaSurvey.Infrastructure.Hubs;
using MaSurvey.Infrastructure.SqlTableDependency;
using MaSurvey.Infrastructure.SqlTableDependency.Middleware;

using MaSurvey.Persistence;
using MediatR;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin", builder =>
    {
        builder.WithOrigins("http://localhost:3000")
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});
builder.Services.AddSignalR(e => {
    e.MaximumReceiveMessageSize = 102400000;
    e.EnableDetailedErrors = true;
});
builder.Services.AddPersistenceService();
builder.Services.AddSingleton<DatabaseSubscription<Option>>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowOrigin");
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseDatabaseSubscription<DatabaseSubscription<Option>>("Options");
app.UseEndpoints(endpoints =>
{

    endpoints.MapHub<OptionHub>("/optionshub");
});

app.MapControllers();

app.Run();
