using Again.Domain.Entities;
using Again.Domain.Interfaces;
using Again.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Again.Infrastructure.Repositories;

public class WasteRepository:IWasteRepository
{
    private readonly ApplicationDbContext _context;

    public WasteRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Waste> GetByIdAsync(Guid id)
    {
        return await _context.wastes.FindAsync(id);
    }

    public async Task<IEnumerable<Waste>> GetAllAsync()
    {
        return await _context.wastes.ToListAsync();
    }

    public async Task AddAsync(Waste waste)
    {
        _context.wastes.Add(waste);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Waste waste)
    {
        _context.wastes.Update(waste);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var waste = await _context.wastes.FindAsync(id);
        if (waste is not null)
        {
            _context.wastes.Remove(waste);
            await _context.SaveChangesAsync();
        }
    }
}