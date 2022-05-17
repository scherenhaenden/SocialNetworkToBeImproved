namespace DataAccess.Models;

public class Address: TEntity, ITEntity
{
    
    public string PostalCode { get; set; }
    public string Address1 { get; set; }
    public Guid CountryGuid { get; set; }
    public City City { get; set; }
    
}