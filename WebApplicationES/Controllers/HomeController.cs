using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationES.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public void Index(emailData1 _emapDetails)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(_emapDetails.To1);
            mail.From = new MailAddress("sampathpanikara@gmail.com");
            mail.Subject = _emapDetails.Subject;
            string Body = _emapDetails.Body;
            mail.Body = Body;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("sampathpanikara@gmail.com", "7036310703"); // Enter seders User name and password  
            smtp.EnableSsl = true;
           smtp.Send(mail);
             }
    }
}