﻿using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UsuariosApi.Models;
using UsuariosApi.Services.Interfaces;

namespace UsuariosApi.Services
{
    public class TokenService : ITokenService
    {
        public string GenerateToken(Usuario usuario)
        {
            Claim[] claims = new Claim[]
            {
                new Claim("Username", usuario.UserName),
                new Claim("id", usuario.Id),
                new Claim(ClaimTypes.DateOfBirth, usuario.DataNascimento.ToString())
            };

            var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("uysfguyagaiutfgauifg7i6agdhiaouf8a789ad5."));

            var signingCredentials = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken
                (
                    expires: DateTime.Now.AddMinutes(10),
                    claims: claims,
                    signingCredentials: signingCredentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
