using Again.Domain.Entities;
using Again.Domain.Interfaces;
using Again.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Again.Infrastructure.Repositories;

public class UserRepository:IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<User> GetUserByUserNameAndPasswordAsync(string userName, string password)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.UserName == userName && u.Password == password);
    }

    public Task<User> GetUserByUsernameAndPasswordAsync(object username, string loginRequestPassword)
    {
        throw new NotImplementedException();
    }
}