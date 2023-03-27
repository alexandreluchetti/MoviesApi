using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dto;

public class UpdateMovieDto
{
    [Required(ErrorMessage = "O título do filme é obrigatório!")]
    public string Title { get; set; }
    [Required(ErrorMessage = "O Gênero do filme é obrigatório!")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres.")]
    public string Gender { get; set; }
    [Required(ErrorMessage = "A duração do filme é obrigatória!")]
    [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos.")]
    public int Duration { get; set; }
    [Required(ErrorMessage = "O ano de lançamento do filme é obrigatório!")]
    public int Year { get; set; }
    [Required(ErrorMessage = "O diretor do filme é obrigatório!")]
    public string Director { get; set; }
}
