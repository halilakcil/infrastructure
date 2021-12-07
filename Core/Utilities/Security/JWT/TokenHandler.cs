//using Microsoft.Extensions.Configuration;
//using Microsoft.IdentityModel.Tokens;
//using System;
//using System.Collections.Generic;
//using System.IdentityModel.Tokens.Jwt;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;
//using Core.Entities.Concrete;

//namespace Core.Utilities.Security.JWT
//{
//    public class TokenHandler
//    {
//        IConfiguration Configuration { get; set; }
//        public TokenHandler(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }
//        //Token üretecek metot.
//        public AccessToken CreateAccessToken(User user)
//        {
//            var tokenInstance = new AccessToken();

//            //Security  Key'in simetriğini alıyoruz.
//            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["TokenOptions:SecurityKey"]));

//            //Şifrelenmiş kimliği oluşturuyoruz.
//            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

//            //Oluşturulacak token ayarlarını veriyoruz.
//            tokenInstance.Expiration = DateTime.Now.AddMinutes(5);
//            JwtSecurityToken securityToken = new JwtSecurityToken(
//                issuer: Configuration["TokenOptions:Issuer"],
//                audience: Configuration["TokenOptions:Audience"],
//                expires: tokenInstance.Expiration,//Token süresini 5 dk olarak belirliyorum
//                notBefore: DateTime.Now,//Token üretildikten ne kadar süre sonra devreye girsin ayarlıyouz.
//                signingCredentials: signingCredentials
//                );

//            //Token oluşturucu sınıfında bir örnek alıyoruz.
//            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

//            //Token üretiyoruz.
//            tokenInstance.Token = tokenHandler.WriteToken(securityToken);

//            return tokenInstance;
//        }

//        //Refresh Token üretecek metot.
//        public string CreateRefreshToken()
//        {
//            byte[] number = new byte[32];
//            using (RandomNumberGenerator random = RandomNumberGenerator.Create())
//            {
//                random.GetBytes(number);
//                return Convert.ToBase64String(number);
//            }
//        }
//    }
//}
