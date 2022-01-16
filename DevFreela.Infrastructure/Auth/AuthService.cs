using DevFreela.Core.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace DevFreela.Infrastructure.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;
        
        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string ComputeSha256Hash(string password)
        {
            using (var sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                var builder = new StringBuilder();

                for (var index = 0; index < bytes.Length; index++)
                {
                    builder.Append(bytes[index].ToString("x2")); // x2 convert to hex
                }

                return builder.ToString();
            }
        }

        public string GenerateJwtToken(string email, string role)
        {
            var issuer = _configuration["Jwt:Issuer"];
            var audience = _configuration["Jwt:Audience"];
            var key = _configuration["Jwt:Key"];

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim("userName", email),
                new Claim(ClaimTypes.Role, role),
            };

            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                expires: DateTime.Now.AddHours(8),
                signingCredentials: credentials,
                claims: claims
            );

            var tokenHandler = new JwtSecurityTokenHandler();

            return tokenHandler.WriteToken(token);
        }
    }
}