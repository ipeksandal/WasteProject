using Again.Domain.Dtos;
using Again.Domain.Entities;
using Again.Domain.Interfaces;

namespace Again.Application.Services;

public class AuthService
{
    private readonly IUserRepository _userRepository;

    public AuthService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> LoginAsync(LoginRequest loginRequest)
    {
        return await _userRepository.GetUserByUsernameAndPasswordAsync(loginRequest.UserName, loginRequest.Password);
    }
}