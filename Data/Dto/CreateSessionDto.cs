using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Data.Dto;

public class CreateSessionDto
{
    public int MovieId { get; set; }
    public int CinemaId { get; set; }
}
