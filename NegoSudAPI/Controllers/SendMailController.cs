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
            if (mailer is null)
            {
                throw new ArgumentNullException("mailer");
            }
            new SendMail().SendIt(mailer.EnvoyePar, mailer.Sujet, mailer.Corps);

            Ok(mailer);
        }


    }


}


