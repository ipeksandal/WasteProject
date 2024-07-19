using Again.Application.Services;
using Again.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Again.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class WasteController:ControllerBase
{
    private readonly WasteService _wasteService;

    public WasteController(WasteService wasteService)
    {
        _wasteService = wasteService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Waste>> GetWaste(Guid id)
    {
        var waste = await _wasteService.GetWasteByIdAsync(id);
        if (waste == null)
        {
            return NotFound();
        } 
        return Ok(waste);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Waste>>> GetAllWaste()
    {
        return Ok(await _wasteService.GetAllWasteAsync());
    }

    [HttpPost]
    public async Task<ActionResult> PostWaste([FromBody] Waste waste)
    {
        await _wasteService.AddWasteAsync(waste);
        return CreatedAtAction(nameof(GetWaste), new { id = waste.Id }, waste);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> PutAtik(Guid id, [FromBody] Waste waste)
    {
        if (id != waste.Id)
        {
            return BadRequest();
        }

        await _wasteService.UpdateWasteAsync(waste);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteWaste(Guid id)
    {
        await _wasteService.DeleteWasteAsync(id);
        return NoContent();
    }
    

}