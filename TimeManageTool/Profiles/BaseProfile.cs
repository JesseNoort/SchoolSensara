using AutoMapper;
using TimeManageTool.Data;

namespace TimeManageTool.Profiles;

public abstract  class BaseProfile <TEntity, TDTO> :Profile
where TEntity : class,IEntity
where  TDTO: class,IDTO
{
    public BaseProfile() 
    { 
        CreateMap<TEntity, TDTO>();
        CreateMap<TDTO, TEntity>().ReverseMap();
    }   
}

