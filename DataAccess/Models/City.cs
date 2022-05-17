namespace DataAccess.Models;

public class City:  TEntity, ITEntity
{
    public string Name { get; set; }
    public Guid CountryGuid { get; set; }
    public Country Country { get; set; }
    public double Lat { get; set; }
    public double Lon { get; set; }
    public string PostalCode { get; set; }
}