using MoviesApi.Data.Dto;
using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.Dto;

public class ReadMovieDto
{
    public string Title { get; set; }
    public string Gender { get; set; }
    public int Duration { get; set; }
    public int Year { get; set; }
    public string Director { get; set; }
    public DateTime QueryTime { get; set; } = DateTime.Now;
    public ICollection<ReadSessionDto> Sessions { get; set; }
}
