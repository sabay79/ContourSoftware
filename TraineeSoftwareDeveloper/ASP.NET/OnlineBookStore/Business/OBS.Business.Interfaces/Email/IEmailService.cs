using OBS.Business.Models.Email;

namespace OBS.Business.Interfaces.Email
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }
}
