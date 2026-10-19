using Kurumsal.Application.DTOs.Role;
using Kurumsal.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Kurumsal.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly IAppRoleService _service;

        public RoleController(IAppRoleService service) => _service = service;

        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _service.GetAllAsync());

        [HttpGet("tenant/{tenantId:guid}")]
        public async Task<IActionResult> GetByTenant(Guid tenantId)
            => Ok(await _service.GetByTenantIdAsync(tenantId));

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var item = await _service.GetByIdAsync(id);
            return item is null ? NotFound() : Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AppRoleCreateDto dto)
        {
            var created = await _service.CreateAsync(dto);
            return Ok(created);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] AppRoleUpdateDto dto)
        {
            var updated = await _service.UpdateAsync(dto);
            return Ok(updated);
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ok = await _service.DeleteAsync(id);
            return ok ? Ok() : NotFound();
        }
    }
}
