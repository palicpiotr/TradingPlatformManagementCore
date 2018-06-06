using System.Threading.Tasks;

namespace TradingPlatformManagement.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
