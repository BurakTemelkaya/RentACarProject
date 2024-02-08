using Core.Security.Entities;
using Core.Security.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.AuthService
{
    public interface IAuthService
    {
        Task<AccessToken> CreateAccessToken(User user);
        Task<RefreshToken> CreateRefreshToken(User user, string ipAddress);
        Task<RefreshToken> AddRefreshToken(RefreshToken refreshToken);
    }
}
