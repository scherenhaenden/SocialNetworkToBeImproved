using DataAccess.DataBase.Core.Domain.BaseDomain;

namespace DataAccess.Models;

public class Country:  TEntity, ITEntity
{
    public string Name { get; set; }
    public string AlphaTwoCode { get; set; }
    public string AlphaThreeCode { get; set; }
}