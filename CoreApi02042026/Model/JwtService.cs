using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CoreApi02042026.Model
{
    public class JwtService
    {
        private readonly IConfiguration _config;

        public JwtService(IConfiguration config)
        {
            _config = config;
        }

        public string GenerateToken(string username, string role)
        {
            // ✅ Step 1 — Define claims (data stored inside the token)
            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub,   username),   // Subject = username
            new Claim(JwtRegisteredClaimNames.Jti,   Guid.NewGuid().ToString()), // Unique token ID
            new Claim(JwtRegisteredClaimNames.Iat,   DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString()), // Issued at
            new Claim(ClaimTypes.Name,               username),   // Used by User.Identity.Name
         //   new Claim(ClaimTypes.Role,               role)        // Used by [Authorize(Roles="Admin")]
        };

            // ✅ Step 2 — Create signing key from secret
            var key = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(_config["Jwt:Key"]!));

            // ✅ Step 3 — Create signing credentials using HMAC SHA256
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // ✅ Step 4 — Set token expiry
            var expiry = DateTime.UtcNow.AddMinutes(
                            double.Parse(_config["Jwt:ExpiryInMinutes"]!));

            // ✅ Step 5 — Build the token
            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                notBefore: DateTime.UtcNow,    // valid from now
                expires: expiry,
                signingCredentials: creds
            );
            // ✅ Step 6 — Serialize token to string
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
