using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dto;

public class UpdateCinemaDto
{
    [Required(ErrorMessage = "O campo de nome é obrigatório.")]
    public string Name { get; set; }
}
