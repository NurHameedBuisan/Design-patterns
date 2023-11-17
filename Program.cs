
using Student.Web.Api.Data;
using Student.Web.Api.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();// Builder Pattern : Creational design pattern
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StudentDataContext>();
builder.Services.AddScoped<IPupilRepository, PupilRepository>();
builder.Services.AddScoped<ISubjectRepository, SubjectRepository>();
builder.Services.AddScoped<IGradeRepository, GradeRepository>();

builder.Services.AddSingleton<IGradeRepository, GradeRepository>();//Singleton Pattern : Creational design pattern



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
