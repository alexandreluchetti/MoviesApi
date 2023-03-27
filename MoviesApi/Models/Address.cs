using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models;

public class Address
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O logradouro é obrigatório!")]
    public string PublicPlace { get; set; }
    [Required(ErrorMessage = "O número do endereço é obrigatório!")]
    public int Number { get; set; }
    [Required(ErrorMessage = "O código postal é obrigatório!")]
    public string ZipCode { get; set; }
    public string Neighborhood { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public virtual Cinema Cinema { get; set; }
}
