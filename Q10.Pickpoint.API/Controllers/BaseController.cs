using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Q10.Pickpoint.Business.Services;

namespace Q10.Pickpoint.API.Controllers;

[ApiController]
[EnableCors("CorsApi")]
[Route("[controller]")]
public abstract class BaseController<T> : Controller where T : IGeneralService
{
    protected IMapper Mapper { get; }
    protected T Service { get; }

    protected BaseController(IMapper mapper, IGeneralService generalService)
    {
        Mapper = mapper;
        Service = (T)generalService;
    }
}