using ApiSample;
using ApiSample.Controllers;
using ApiSample.Models;
using ApiSample.Services;

public static class MyMappings
{   
    public static void MapMiniApis(this WebApplication app)
    {
        app.MapGet("mini/hello", (string name) =>
        {
            return $"Hello {name}!";
        }).WithTags("Excample");

        app.MapPost("mini/person", (Person person) =>
        {
            return new Response
            {
                Message = $"Hello {person.Firstname} {person.Lastname}!"
            };

        }).WithTags("Excample");
    }

}