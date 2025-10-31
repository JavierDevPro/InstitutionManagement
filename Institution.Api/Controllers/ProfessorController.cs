using Institution.Application.Dtos;
using Institution.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Institution.Api.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ProfessorController: ControllerBase
{
    private readonly IProfessorService _service;

    public ProfessorController(IProfessorService service)
    {
        _service = service;
    }

    public async Task<ActionResult<IEnumerable<ProfessorDto>>> GetAll()
    {
        var result = await _service.GetAll();
        return Ok(result);
    }

    public async Task<ActionResult<ProfessorDto>> Create(ProfessorCreateDto professor)
    {
        
    }
}