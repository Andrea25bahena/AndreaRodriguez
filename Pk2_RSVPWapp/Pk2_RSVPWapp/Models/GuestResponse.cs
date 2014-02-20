using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace pk2_RSVWapp.Models

{
    public class GuestReponse

    {
        [Required(ErrorMessage = "Por favor ingrese su nombre.")]
        public string Name { get; set; }

        [Required(ErrorMessage= "Por favor ingrese su correo electronico.")]
        [RegularExpression(".+//@.+//..+",ErrorMessage = "Favor de ingresar una cuenta de correo valida")]
        public string Email { get; set; }

        [Required(ErrorMessage= "por favor ingrese su numero telefonico.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "por favor ingrese su numero telefonico.")]
        public bool? WillAttend { get ; set;}
    }


    }



