using System.ComponentModel.DataAnnotations;
using DataAccess.DataBase.Core.Domain.BaseDomain;

namespace DataAccess.Models;

public class Gender:  TEntity, ITEntity
{
    // this is an enum like table
    public char GenderType { get; set; }
}