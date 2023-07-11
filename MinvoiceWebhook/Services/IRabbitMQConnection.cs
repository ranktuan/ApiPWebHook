
using Microsoft.AspNetCore.Mvc.Filters;
using MinvoiceWebhook.Models;
using RabbitMQ.Client;
using System.Web.Http.Controllers;

namespace MinvoiceWebhook.Services
{
    public interface IRabbitMQConnection
    {
        IConnection CreateConnection();
        void PushMessage(MessageMOD message);

        
    }
    public interface ITokenService
    {
        void OnAuthorization(AuthorizationFilterContext context);
        string GenerateToken(string username);
        bool ValidateToken(string token);
        object OnAuthorization();
    }


}
