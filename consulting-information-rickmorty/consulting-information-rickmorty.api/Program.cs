using consulting_information_rickmorty.api.Service;
using consulting_information_rickmorty.api.Service.Interface;
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

app.Run();

