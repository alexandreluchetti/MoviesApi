using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dto;

public class ReadAddressDto
{
    public int Id { get; set; }
    public string PublicPlace { get; set; }
    public int Number { get; set; }
    public string ZipCode { get; set; }
    public string Neighborhood { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
}
