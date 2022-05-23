using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.DataBase.Core.Domain.BaseDomain;

// ReSharper disable once InconsistentNaming
public class TEntity: BaseTEntity
{
    [Key]
    [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
    public new int Id { get; set; }

}