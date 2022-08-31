using GraphQlServer.Context;
using GraphQlServer.GraphQL;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql());
builder.Services.AddDbContext<ApplicationContext>();
//builder.Services.AddPooledDbContextFactory<ApplicationContext>(options => options.UseNpgsql());

builder.Services
    .AddGraphQLServer()
    .RegisterDbContext<ApplicationContext>()
    .AddQueryType<Query>()
    .AddMutationType<Mutations>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();


var app = builder.Build();

app.MapGraphQL("/api");

app.UseWebSockets();

app.Run();
