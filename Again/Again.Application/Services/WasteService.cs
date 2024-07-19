using Again.Domain.Entities;
using Again.Domain.Interfaces;

namespace Again.Application.Services;

public class WasteService
{
    private readonly IWasteRepository _wasteRepository;

    public WasteService(IWasteRepository wasteRepository)
    {
        _wasteRepository = wasteRepository;
    }

    public async Task<Waste> GetWasteByIdAsync(Guid id)
    {
        return await _wasteRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Waste>> GetAllWasteAsync()
    {
        return await _wasteRepository.GetAllAsync();
    }

    public async Task AddWasteAsync(Waste waste)
    {
        await _wasteRepository.AddAsync(waste);
    }
    public async Task UpdateWasteAsync(Waste waste)
    {
        await _wasteRepository.UpdateAsync(waste);
    }
    public async Task DeleteWasteAsync(Guid id)
    {
        await _wasteRepository.DeleteAsync(id);
    }
    
}