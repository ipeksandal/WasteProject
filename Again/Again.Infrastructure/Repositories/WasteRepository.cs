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
        return await _context.Wastes.FindAsync(id);
    }

    public async Task<IEnumerable<Waste>> GetAllAsync()
    {
        return await _context.Wastes.ToListAsync();
    }

    public async Task AddAsync(Waste waste)
    {
        _context.Wastes.Add(waste);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Waste waste)
    {
        _context.Wastes.Update(waste);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var waste = await _context.Wastes.FindAsync(id);
        if (waste is not null)
        {
            _context.Wastes.Remove(waste);
            await _context.SaveChangesAsync();
        }
    }
}