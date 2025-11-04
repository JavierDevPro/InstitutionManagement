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

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProfessorDto>>> GetAll()
    {
        var result = await _service.GetAll();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<ProfessorDto>> Create(ProfessorCreateDto professor)
    {
        var result = await _service.Create(professor);
        return (result != null) ? Created($"/{result.Id}", result) : NoContent();
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<ProfessorDto>> Update(int id, ProfessorUpdateDto professor)
    {
        var result = await _service.Update(id, professor);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpDelete]
    public async Task<ActionResult<bool>> Delete(int id)
    {
        var result = await _service.Delete(id);
        return (result != null) ? result : NotFound();
    }
}