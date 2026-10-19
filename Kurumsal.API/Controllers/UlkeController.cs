using Kurumsal.Application.DTOs.Ulke;
using Kurumsal.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UlkeController : ControllerBase
{
    private readonly IUlkeService _ulkeService;

    public UlkeController(IUlkeService ulkeService)
    {
        _ulkeService = ulkeService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _ulkeService.GetAllAsync();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _ulkeService.GetByIdAsync(id);
        return result is null ? NotFound() : Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create(UlkeCreateDto dto)
    {
        var result = await _ulkeService.CreateAsync(dto);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update(UlkeUpdateDto dto)
    {
        var result = await _ulkeService.UpdateAsync(dto);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var success = await _ulkeService.DeleteAsync(id);
        return success ? Ok() : NotFound();
    }
}
