
using NegoSudAPI.Data;
using NegoSudAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace NegoSudAPI.Services.MailerService
{
    public class MailerService : IMailerService
    {
        private readonly NegosudDbContext _context;

        public MailerService(NegosudDbContext context)
        {
            _context = context;
        }

        public async Task<List<Mailer>> SendMailer(Mailer mailer)
        {
            if (_context.mailers == null)
            {
                throw new ArgumentNullException(nameof(_context.mailers), "tout est vide.");
            }
            _context.mailers.Add(mailer);
            await _context.SaveChangesAsync();
            return await _context.mailers.ToListAsync();
        }
        public async Task<List<Mailer>?> SupprimerMailer(int id)
        {
            if (_context.mailers == null)
            {
                throw new ArgumentNullException(nameof(_context.mailers), "tout est vide.");
            }
            var mailer = await _context.mailers.FindAsync(id);
            if (mailer is null)
                return null;

            _context.mailers.Remove(mailer);
            await _context.SaveChangesAsync();

            return await _context.mailers.ToListAsync();
        }

        public Task<List<Mailer>> RecupererToutMailers()
        {
            if (_context.mailers == null)
            {
                throw new ArgumentNullException(nameof(_context.mailers), "tout est vide.");
            }
            var mailers = _context.mailers.ToListAsync();
            return mailers;
        }

        public async Task<Mailer?> RecupererMailer(int id)
        {
            if (_context.mailers == null)
            {
                throw new ArgumentNullException(nameof(_context.mailers), "tout est vide.");
            }
            var mailer = await _context.mailers.FindAsync(id);
            if (mailer is null)
                return null;

            return mailer;
        }

        public async Task<List<Mailer>?> ModifierMailer(int id, Mailer request)
        {
            if (_context.mailers == null)
            {
                throw new ArgumentNullException(nameof(_context.mailers), "tout est vide.");
            }
            var mailer = await _context.mailers.FindAsync(id);
            if (mailer is null)
                return null;

            mailer.Corps = request.Corps;
            mailer.Sujet = request.Sujet;
            mailer.EnvoyePar = request.EnvoyePar;
            mailer.DateInscription = request.DateInscription;
            mailer.receptionneur = request.receptionneur;
 
            await _context.SaveChangesAsync();

            return await _context.mailers.ToListAsync();
        }


    }
}
