using GraphQlServer.Context;
using GraphQlServer.GraphQL;
using GraphQlServer.Repository;
using GraphQlServer.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql());
builder.Services.AddDbContext<ApplicationContext>();
//builder.Services.AddPooledDbContextFactory<ApplicationContext>(options => options.UseNpgsql());

builder.Services.AddScoped<IAccountRepository, AccountRepository>();

builder.Services
    .AddGraphQLServer()
    .RegisterDbContext<ApplicationContext>()
    .AddQueryType<Query>()
    .AddMutationType<Mutations>();

var app = builder.Build();

app.MapGraphQL("/api");

app.Run();
