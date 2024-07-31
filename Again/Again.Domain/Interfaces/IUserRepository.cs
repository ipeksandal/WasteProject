using Again.Domain.Entities;

namespace Again.Domain.Interfaces;

public interface IUserRepository
{
    Task<User> GetUserByUserNameAndPasswordAsync(string userName, string password);
    Task<User> GetUserByUsernameAndPasswordAsync(object username, string loginRequestPassword);
}