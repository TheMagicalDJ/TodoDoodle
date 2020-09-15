using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TodoDoodle.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public string Mailforsendelse { get; set; }

        public List <string> TodoDoodles { get; set; }


        //public async Task<IActionResult> OnPostAsync()
        //{
        //    Product = await db.Products.FindAsync(Id);
        //    if (ModelState.IsValid)
        //    {

        //        var body = "";
        //        using (var smtp = new SmtpClient())
        //        {
        //            var credential = new NetworkCredential
        //            {
        //                UserName = "example@gmail.com",  // replace with valid value
        //                Password = "password"  // replace with valid value
        //            };
        //            smtp.Credentials = credential;
        //            smtp.Host = "smtp.gmail.com";
        //            smtp.Port = 587;
        //            smtp.EnableSsl = true;
        //            var message = new MailMessage();
        //            message.To.Add(OrderEmail);
        //            message.Subject = "Fourth Coffee - New Order";
        //            message.Body = body;
        //            message.IsBodyHtml = true;
        //            message.From = new MailAddress("example@gmail.com");
        //            await smtp.SendMailAsync(message);
        //        }
        //        return RedirectToPage("OrderSuccess");
        //    }
        //    return Page();
        //}

        public void OnGet()
        {
        }
    }
}
