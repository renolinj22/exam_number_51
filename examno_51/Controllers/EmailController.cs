using Microsoft.AspNetCore.Mvc;
using examno_51.Models;
using System.Diagnostics;
using System.Net.Mail;

using System.Runtime.Intrinsics.X86;

namespace examno_51.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult Emailpage()
        { 
            return View();
        }
       [HttpPost]
        public IActionResult Emailpage(email obj)
        {

            string name = obj.Name;
            string email = obj.Email;
            string Subject = obj.Subject;
            string message = obj.Message;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(email);
            mail.To.Add(new MailAddress("renolinj22@gmail.com"));
            mail.Subject = "You have A meassage";
            mail.IsBodyHtml = true;
            mail.Body = $" <h2>Name:{name} </h2></br><h2>Email:{email}</h2></br><h2>subject:{Subject}</h2></br><h2>Message: {message} </h2> <h1>hi renolin </h2>";


            System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);

            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new System.Net.NetworkCredential("jeyasekar121@gmail.com", "igey wytj ehnt xzbk");
            smtpClient.Send(mail);
           


            return View();
        }
       
    }
}
//See hear you have massage