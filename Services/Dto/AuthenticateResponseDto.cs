using UES.Models;

namespace UES.Services.Dto
{
    public class AuthenticateResponseDto
    {
        public Guid Id { get; set; }
        public string? Username { get; set; }
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }

        public AuthenticateResponseDto(User user, string token)
        {
            Id = user.Id;
            Username = user.UserName;
            Token = token;
            RefreshToken = user.RefreshToken;
        }
    }
}
