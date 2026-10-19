using Kurumsal.Application.DTOs.Ilce;
using Kurumsal.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IlceController : ControllerBase
{
    private readonly IIlceService _ilceService;

    public IlceController(IIlceService ilceService)
    {
        _ilceService = ilceService;
    }

    // ?sehirId=... gönderirsen sadece o şehrin ilçeleri gelir
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] Guid? sehirId)
    {
        var result = sehirId.HasValue
            ? await _ilceService.GetBySehirIdAsync(sehirId.Value)
            : await _ilceService.GetAllAsync();

        return Ok(result);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _ilceService.GetByIdAsync(id);
        return result is null ? NotFound() : Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] IlceCreateDto dto)
    {
        var result = await _ilceService.CreateAsync(dto);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] IlceUpdateDto dto)
    {
        var result = await _ilceService.UpdateAsync(dto);
        return Ok(result);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var success = await _ilceService.DeleteAsync(id);
        return success ? Ok() : NotFound();
    }
}
