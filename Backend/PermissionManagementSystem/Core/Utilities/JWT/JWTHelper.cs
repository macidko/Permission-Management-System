using Core.Entities;
using Core.Utilities.Encryption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;


namespace Core.Utilities.JWT;

public class JWTHelper : ITokenHelper
{
    private readonly TokenOptions tokenOptions;

    public JWTHelper(TokenOptions tokenOptions)
    {
        this.tokenOptions = tokenOptions;
    }

    public AccessToken CreateToken(BaseUser user, List<OperationClaim> operationClaims)
    {
        //token zamanı belirle
        DateTime expirationTime = DateTime.Now.AddMinutes(tokenOptions.ExpirationTime);

        //güvenlik anahtarı
        SecurityKey key = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey);

        //şifreli imzalama bilgileri
        SigningCredentials signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

        //tokenı oluştur
        JwtSecurityToken jwt = new JwtSecurityToken(
            issuer: tokenOptions.Issuer,
            audience: tokenOptions.Audience,
            claims: SetAllClaims(user, operationClaims.Select(i => i.Name).ToList()),
            notBefore: DateTime.Now,
            expires: expirationTime,
            signingCredentials: signingCredentials
        );

        //tokenı yazdır.
        JwtSecurityTokenHandler jwtSecurityTokenHandler = new();
        string jwtToken = jwtSecurityTokenHandler.WriteToken(jwt);

        //tokenı AccessToken nesnesi olarak döndür.
        return new AccessToken() { Token = jwtToken, ExpirationTime = expirationTime };
    }
    protected IEnumerable<Claim> SetAllClaims(BaseUser user, List<string> operationClaims)
    {
        List<Claim> claims = new List<Claim>();
        claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
        claims.Add(new Claim(ClaimTypes.Name, user.Username));
        claims.Add(new Claim(ClaimTypes.Email, user.Email));

        foreach (var operationClaim in operationClaims)
        {
            claims.Add(new Claim(ClaimTypes.Role, operationClaim));
        }

        claims.Add(new Claim("Tobeto", "abc"));

        return claims;
    }
}
