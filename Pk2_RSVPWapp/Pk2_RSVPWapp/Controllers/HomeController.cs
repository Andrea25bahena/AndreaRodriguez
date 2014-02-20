using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pk2_RSVWapp.Models;



namespace Pk2_RSVPWapp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
           

            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour <12 ?
            "Buenos dias!!" : "Buenos tardes!!";
             return View();
        }
        //rederea el link de l forma del resvp
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
       
        //renderea el link de la forma del RSVP
        [HttpPost]
        public ViewResult RsvpForm(GuestReponse guestResponse)//tipo de objeto atributos nombre enviar la informacion se metan al url con parametro el methodo post 
        {
            if (ModelState.IsValid)
            {
            //TODO: Enviar respuesta al correo del organizador
            return View("Agradecimientos", guestResponse);//renderear la vista url que envio el explorador pasa el objeto 
              
        }
        else
    {     
        return View();
    }
}
}
}


    
