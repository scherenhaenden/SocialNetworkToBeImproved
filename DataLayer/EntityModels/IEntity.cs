using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.EntityModels;

public interface IEntity
{
    [Key]
    [Required]
    [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    //public DateTime UpdatedDate { get; set; }
}

public class Entity: IEntity
{
    [Key]
    [Required]
    [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
}

public class BaseEntity: IEntity
{
    public int Id { get; set; }
    //public DateTime UpdatedDate { get; set; }
}