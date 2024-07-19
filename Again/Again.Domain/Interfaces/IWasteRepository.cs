using Again.Domain.Entities;

namespace Again.Domain.Interfaces;

public interface IWasteRepository
{
    Task<Waste> GetByIdAsync(Guid id);
    Task<IEnumerable<Waste>> GetAllAsync();
    Task AddAsync(Waste waste);
    Task UpdateAsync(Waste waste);
    Task DeleteAsync(Guid id);
}