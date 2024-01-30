
namespace Base.App.Emails
{
    public interface IEmailSender
    {
        Task SendEmail(EmailMessage message);
    }
}
