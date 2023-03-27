using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MoviesApi.Data.Dto;
using MoviesApi.Models;
using MoviesAPI.Data;

namespace MoviesApi.Controller;

[ApiController]
[Route("[controller]")]
public class SessionController : ControllerBase
{
    private MovieContext _context;
    private IMapper _mapper;

    public SessionController(MovieContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddSession(CreateSessionDto sessionDto)
    {
        Session session = _mapper.Map<Session>(sessionDto);
        _context.Sessions.Add(session);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetSessionById), new { movieId = session.MovieId, cinemaId = session.CinemaId }, session);
    }

    [HttpGet]
    public IEnumerable<ReadSessionDto> GetSessions()
    {
        return _mapper.Map<List<ReadSessionDto>>(_context.Sessions.ToList());
    }

    [HttpGet("{movieId}/{cinemaId}")]
    public IActionResult GetSessionById(int movieId, int cinemaId)
    {
        Session session = _context.Sessions.FirstOrDefault(session => session.MovieId == movieId && session.CinemaId == cinemaId);
        if (session != null)
        {
            ReadSessionDto sessionDto = _mapper.Map<ReadSessionDto>(session);

            return Ok(sessionDto);
        }
        return NotFound();
    }
}
