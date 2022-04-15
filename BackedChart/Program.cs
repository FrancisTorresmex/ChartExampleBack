using BackedChart.Models;
using BackedChart.Models.Response;
using Microsoft.EntityFrameworkCore;

string policy = "MyPolicy";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ChartExampleContext>(); //para la conexión con la bd

builder.Services.AddCors(options => //opciones de CORS
{
    options.AddPolicy(policy, build =>
    {        
        build.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost") //solo se permitira conexión con localhost (por seguridad solo se debe permitir en donde se vaya a usar)
        .AllowAnyOrigin() //permitir cualquier tipo de header
        .AllowAnyMethod(); //permitir cualquier metodo (get,post,delete,put)
    });
});

var app = builder.Build();

app.UseCors(policy); //Se agrega la politica de Cors

app.MapGet("/", () => "Hello World!");

app.MapGet("/stock", async (ChartExampleContext context) => // al escribir stock hara la conexión con el context
{
    return await context.Stocks.Select(x => new StockResponse
    {
        Name = x.Beer.Name,
        Quantity = (int)x.Quantity  
    }).ToListAsync();
});

app.Run();
