using Kurumsal.Application.DTOs.Sehir;
using Kurumsal.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SehirController : ControllerBase
{
    private readonly ISehirService _sehirService;

    public SehirController(ISehirService sehirService)
    {
        _sehirService = sehirService;
    }

    // ?ulkeId=0000-... gönderirsen sadece o ülkenin şehirleri gelir
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] Guid? ulkeId)
    {
        var result = ulkeId.HasValue
            ? await _sehirService.GetByUlkeIdAsync(ulkeId.Value)
            : await _sehirService.GetAllAsync();

        return Ok(result);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _sehirService.GetByIdAsync(id);
        return result is null ? NotFound() : Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] SehirCreateDto dto)
    {
        var result = await _sehirService.CreateAsync(dto);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] SehirUpdateDto dto)
    {
        var result = await _sehirService.UpdateAsync(dto);
        return Ok(result);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var success = await _sehirService.DeleteAsync(id);
        return success ? Ok() : NotFound();
    }
}
