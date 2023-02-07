using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NegoSudAPI.Models;
using NegoSudAPI.Mail;
using NegoSudAPI.Services.MailerService;

namespace NegoSudAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SendMailController : ControllerBase
    {
        private readonly IMailerService _mailerService;
        public SendMailController(IMailerService mailerService)
        {
            _mailerService = mailerService;
        }

        [HttpPost]
        public void SendMailer(Mailer mailer)
        {
            if (mailer == null || mailer.EnvoyePar == null || mailer.Sujet== null || mailer.Corps== null || mailer.receptionneur == null  )
            {
                throw new ArgumentNullException("mailer");
            }
            var mailing = new SendMail();
            mailing.SendIt(mailer.EnvoyePar, mailer.Sujet, mailer.Corps, mailer.receptionneur);

            Ok( mailing);
        }


    }


}


