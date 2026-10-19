using Kurumsal.Application.DTOs.Sektor;
using Kurumsal.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SektorController : ControllerBase
{
    private readonly ISektorService _sektorService;

    public SektorController(ISektorService sektorService)
    {
        _sektorService = sektorService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _sektorService.GetAllAsync();
        return Ok(result);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _sektorService.GetByIdAsync(id);
        return result is null ? NotFound() : Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] SektorCreateDto dto)
    {
        var result = await _sektorService.CreateAsync(dto);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] SektorUpdateDto dto)
    {
        var result = await _sektorService.UpdateAsync(dto);
        return Ok(result);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var success = await _sektorService.DeleteAsync(id);
        return success ? Ok() : NotFound();
    }
}
