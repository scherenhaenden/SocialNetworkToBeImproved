using AutoMapper;
using DataAccess.DataBase.Core.UnitiesOfWork;
using DataAccess.Models;


namespace DataAccess.TemporaryProviders;

public interface IGenderDataProvider
{
    IList<Gender> GetAllGenders();
}

public class GenderDataProvider: IGenderDataProvider
{
    private readonly IUnitOfWorkV2 _unitOfWork;

    public GenderDataProvider(IUnitOfWorkV2 unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IList<Gender> GetAllGenders()
    {
        var values = _unitOfWork.Gender.GetAll().ToList();
        var config = new MapperConfiguration(cfg => cfg.CreateMap<DataLayer.EntityModels.Gender, Gender>());
        
        //var mapper = config.CreateMapper();
// or
        var mapper = new Mapper(config);
        var dto = mapper.Map<List<Gender>>(values);

        return dto;
    }
}