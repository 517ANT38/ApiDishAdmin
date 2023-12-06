

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddCors(x => x.AddPolicy("MyPolicy", b =>
//            b.AllowAnyMethod()
//                .AllowAnyHeader()
//                .SetIsOriginAllowed(origin => true) // allow any origin
//                .AllowCredentials()


//));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//app.UseCors("MyPolicy");
app.UseAuthentication();


app.MapControllers();

app.Run();
