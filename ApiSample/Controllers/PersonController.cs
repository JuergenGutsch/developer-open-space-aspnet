using ApiSample.Models;
using ApiSample.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;
    private readonly HugeDataService _service;

    public PersonController(ILogger<PersonController> logger,
        HugeDataService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet(Name = "GetPersons")]
    public IAsyncEnumerable<Person> Get()
    {
        return _service.LoadManyPersons();
    }
}
