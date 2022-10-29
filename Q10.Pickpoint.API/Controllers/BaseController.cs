using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Q10.Pickpoint.Business.Services;

namespace Q10.Pickpoint.API.Controllers;

[ApiController]
[EnableCors("CorsApi")]
[Route("[controller]")]
public abstract class BaseController : Controller
{
    protected IMapper Mapper { get; }
    protected IBaseService BaseService { get; }

    protected BaseController(IMapper mapper, IBaseService baseService)
    {
        Mapper = mapper;
        BaseService = baseService;
    }
}