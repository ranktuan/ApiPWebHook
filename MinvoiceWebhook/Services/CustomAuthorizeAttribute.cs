using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Web.Http;
public class CustomAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var token = context.HttpContext.Request.Headers["Authorization"].ToString();
        if (string.IsNullOrEmpty(token) || !IsValidToken(token))
        {
            context.Result = new UnauthorizedResult();
        }
    }

    private bool IsValidToken(string token)
    {
        return token == "khsffjdhsfhjklslhgdlsfdlsjhggflhffsdfhdgjkfgkfdsfjldghslogfsa";
    }
}
