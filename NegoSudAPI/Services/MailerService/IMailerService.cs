
using NegoSudAPI.Models;


namespace NegoSudAPI.Services.MailerService
{
    public interface IMailerService
    {
        Task<List<Mailer>> RecupererToutMailers();
        Task<Mailer?> RecupererMailer(int id);
        Task<List<Mailer>> SendMailer(Mailer mailer);
        Task<List<Mailer>?> ModifierMailer(int id, Mailer request);
        Task<List<Mailer>?> SupprimerMailer(int id);
    }
}