using UES.Services;

namespace UES.Authorization
{
    public class JwtMiddleware
    {
        private readonly static string HEADERS_AUTHORIZATION = "Authorization";
        private readonly RequestDelegate _next;
        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context, IUserService userService, IJwtUtils jwtUtils)
        {
            string? token = context.Request.Headers[HEADERS_AUTHORIZATION].FirstOrDefault()?.Split(" ").Last();
            string userId = jwtUtils.ValidateJwtToken(token);
            if (userId != null)
            {
                context.Items["User"] = userService.GetById(userId);
            }
            await _next(context);
        }
    }
}
