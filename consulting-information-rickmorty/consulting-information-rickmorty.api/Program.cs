using consulting_information_rickmorty.api.Models;
using consulting_information_rickmorty.api.Service;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/episode", async ( [FromServices] EpisodeService service) =>  
await service.GetAllEpisodes()).WithName("GetEpisodes").WithTags("Episode");

app.MapGet("/episode/{id}", async (int id, [FromServices] EpisodeService service) =>

await service.GetEpisodeById(id)
    is Episode episode ? Results.Ok(episode) : Results.NotFound())
    .Produces<Episode>(StatusCodes.Status200OK)
    .WithName("GetEpisodesById")
    .WithTags("Episode");

app.Run();

