namespace Encuentro1;

public class MinimalApis
{
    public static void Run(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        app.UseSwagger();

        app.MapGet("/api", () => "Hola Mundo!");

        app.MapPost("/saveUser", () => saveUser());

        app.UseSwaggerUI();

        app.Run();
    }

    public static IResult saveUser()
    {
        //codigo para salvar usuario

        return Results.Ok("El usuario ha sido salvado");
    }
}