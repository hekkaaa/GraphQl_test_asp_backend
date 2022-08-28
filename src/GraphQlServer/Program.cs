using GraphQlServer.Context;
using GraphQlServer.GraphQL;
using GraphQlServer.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql());
builder.Services.AddDbContext<ApplicationContext>();

//builder.Services.AddScoped<IAccountRepository, AccountRepository>();
//builder.Services.AddScoped<IOwnerRepository, OwnerRepository>();

builder.Services.AddGraphQLServer().AddQueryType<Query>();
var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();
app.MapGraphQL("/api");

app.Run();
