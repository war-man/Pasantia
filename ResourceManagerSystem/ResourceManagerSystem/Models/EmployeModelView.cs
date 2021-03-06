﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ResourceManagerSystem.Models
{
    public class EmployeModelView
    {
        //employe sector
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CI { set; get; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre no puede estar vacio")]
        public string Name { set; get; }

        [Display(Name = "Apellido paterno")]
        [Required(ErrorMessage = "El apellido paterno no puede estar vacio")]
        public string FirstName { set; get; }

        [Display(Name = "Apellido materno")]
        [Required(ErrorMessage = "El apellido materno no puede estar vacio")]
        public string LastName { set; get; }

        [Display(Name = "Telefono/Celular")]
        [Required(ErrorMessage = "El Telefono/Celular no puede estar vacio")]
        public int Phone { set; get; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Correo electronico")]
        public string Email { set; get; }



        [Display(Name = "Genero")]
        public Sex Sex { set; get; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de nacimiento")]
        [Required(ErrorMessage = "La fecha de nacimiento no puede estar vacia")]
        public DateTime BirthDate { set; get; }

        [Display(Name = "Estado civil")]
        public CivilState CivilState { set; get; }
        [Display(Name = "Altura")]
        [Required(ErrorMessage = "La altura no puede estar vacia")]
        public int Height { set; get; }

        [Display(Name = "Peso")]
        [Required(ErrorMessage = "El peso no puede estar vacio")]
        public int Weight { set; get; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de admisión")]
        [Required(ErrorMessage = "La fecha de admisión no puede estar vacia")]
        public DateTime AdmissionDate { set; get; }
        //Grade
        [Display(Name = "Analfabeta")]
        public bool Illiterate { set; get; }
        [Display(Name = "Nivel Basico")]
        public bool Basic { set; get; }
        [Display(Name = "Universidad")]
        public bool HighSchool { set; get; }
        [Display(Name = "Tecnico medio")]
        public bool MiddleTechnician { set; get; }
        [Display(Name = "Licenciatura")]
        public bool Degree { set; get; }
        //--EndGrade
        //Inabilities
        [DisplayName("Grado de inhabilidad")]
        public bool IsDisabled { set; get; }
        [Required]
        [DisplayName("Grado de inhabilidad")]
        [Range(0, 100, ErrorMessage = "El rango debe estar entre 0 y 100")]
        public int InhabilitiesGrade { set; get; }
        //contrat sector
        [DisplayName("Cargo operativo")]
        public int OperativeID { set; get; }

        [ForeignKey("Administrative")]
        [DisplayName("Cargo administrativo")]
        public int AdministrativeID { set; get; }
        [DisplayName("Tipo de contrato")]
        public TypeContrat TypeContrat { set; get; }
        [DisplayName("Fecha Inicio de contrato")]
        [DataType(DataType.Date)]
        public DateTime DateStart { set; get; }
        [DisplayName("Fecha Fin de contrato ")]
        [DataType(DataType.Date)]
        public DateTime DateEnd { set; get; }

        public Operative Position { set; get; }
        public Employee Employee { set; get; }
        public Administrative Administrative { set; get; }

    }
}
