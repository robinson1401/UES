using Microsoft.EntityFrameworkCore;
using UES.Authorization;
using UES.Data;
using UES.Models;
using UES.Services.Dto;

namespace UES.Services
{
    public interface IUserService
    {
        Task<User?> GetById(string Id);
        Task<AuthenticateResponseDto?> Authenticate(AuthenticateRequestDto authenticateRequest);
    }
    public class UserService : IUserService
    {
        private readonly IJwtUtils _jwtUtils;
        private readonly UESContext _context;

        public UserService(UESContext context, IJwtUtils jwtUtils)
        {
            _context = context;
            _jwtUtils = jwtUtils;
        }

        public async Task<AuthenticateResponseDto?> Authenticate(AuthenticateRequestDto authenticateRequest)
        {
            User user = await _context.User.Where(u => u.UserName == authenticateRequest.Username && u.Password == authenticateRequest.Password).FirstOrDefaultAsync();
            if (user == null)
            {
                return null;
            }
            string token = _jwtUtils.GenerateJwtToken(user);
            return new AuthenticateResponseDto(user, token);
        }

        public async Task<User?> GetById(string Id)
        {
            if (_context.User == null)
            {
                return null;
            }
            return await _context.User.FindAsync(Id);
        }
    }
}
