using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MinvoiceWebhook.Services
{
    public class TokenProvider
    {
        
        public static string GenerateToken(string username)
        {
            
            string token = "khsffjdhsfhjklslhgdlsfdlsjhggflhffsdfhdgjkfgkfdsfjldghslogfsa";
            if (ValidateToken(token))
            {
                return token;   
            }
            else
            {
                return ("Error");
            }
        }

        public static bool ValidateToken(string token)
        {
            return token == "khsffjdhsfhjklslhgdlsfdlsjhggflhffsdfhdgjkfgkfdsfjldghslogfsa";
        }
    }
}
