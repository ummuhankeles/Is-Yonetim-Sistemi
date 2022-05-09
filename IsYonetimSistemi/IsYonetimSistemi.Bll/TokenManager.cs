using IsYonetimSistemi.Entity.Dto;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IsYonetimSistemi.Bll
{
    public class TokenManager
    {
        IConfiguration configuration;

        public TokenManager(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string CreateAccessToken(DtoLoginPersonel personel)
        {
            // claim
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Email, personel.PersonelEmail),
                new Claim(JwtRegisteredClaimNames.Jti, personel.PersonelId.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, "Token");

            // claim roles
            var claimsRoleList = new List<Claim>
            {
                new Claim("role", "Admin"),
                new Claim("role2", "Yönetici"),
                new Claim("role3", "Personel")
            };

            // security key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Token:Key"]));

            // şifrelenmiş kimlik oluşturma
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // token settings
            var token = new JwtSecurityToken
            (
                issuer: configuration["Tokens:Issuer"], // token dağıtıcı url
                audience: configuration["Tokens:Issuer"], // erişilebilecek apiler
                expires: DateTime.Now.AddDays(1), // 1 günlük token
                notBefore: DateTime.Now, // token üretildekten ne kadar zaman sonra devreye girsin
                signingCredentials: cred, // kimlik verme
                claims: claimsIdentity.Claims // claims verme
            );

            // token oluşturma sınıfı ile örnek alıp üretmek
            var tokenHandler = new { token = new JwtSecurityTokenHandler().WriteToken(token) };
            return tokenHandler.token;
        }
    }
}
