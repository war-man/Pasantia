﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResourceManagerSystem.Models
{
    public class Provider
    {
        public int ProviderID { set; get; }

        [Display(Name = "Nombre de Contacto")]
        [Required(ErrorMessage = "El contacto no puede estar vacio")]
        public int ContactID { set; get; }

        [Display(Name="Nombre del proveedor")]
        [Required(ErrorMessage ="El nombre no puede estar vacia")]
        public string Name { set; get; }

        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "La direccion no puede estar vacia")]
        public string Address { set; get; }

        [Display(Name = "Ciudad")]
        [Required(ErrorMessage = "La ciudad no puede estar vacia")]
        public string City { set; get; }

        public string CompleteName => Name + "-" + Address;


        [Display(Name="Contacto")]
        public Contact Contact { set; get; }


    }
}
