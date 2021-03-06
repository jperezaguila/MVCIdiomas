﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using MVCIdiomas.Models;

namespace MVCIdiomas.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

      
        public ActionResult Alta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Alta(Persona model)
        {
           if (ModelState.IsValid)
           return RedirectToAction("Index");
           return View(model);
        }

        public ActionResult Correo()

        {
            return View();
        }
        //edidot wys wyg - what you see, what you get
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult Correo(Correo model)
        {
            var msg=new MailMessage();
            msg.Subject = model.Asunto;
            msg.Body = model.Mensaje;
            msg.To.Add(model.Destino);
            msg.IsBodyHtml = true;

            var smtp=new SmtpClient();
            try
            {
                smtp.Send(msg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return RedirectToAction("Index");
        }


    }
}