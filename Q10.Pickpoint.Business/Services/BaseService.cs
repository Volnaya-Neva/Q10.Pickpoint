using Q10.Pickpoint.DAL.Repositories;

namespace Q10.Pickpoint.Business.Services;

public abstract class BaseService<T> : IBaseService where T : IGeneralRepository
{
    protected T Repository { get; }

    protected BaseService(IGeneralRepository generalRepository)
    {
        Repository = (T)generalRepository;
    }
}