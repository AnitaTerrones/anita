using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace T1_Diars.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public int Nombre { get; set; }
        

        [Required(ErrorMessage = "El campo Apellidos es obligatorio")]
        public string Apellidos { get; set; }


        [Required(ErrorMessage = "El campo F.Nacimeinto es obligatorio")]
        public string FNacimiento { get; set; }


        [Required(ErrorMessage = "El campo DNI es obligatorio")]
        public string DNI { get; set; }


        [Required(ErrorMessage = "El campo Genero es obligatorio")]
        public decimal Genero { get; set; }


        [Required(ErrorMessage = "El campo Ciudad es obligatorio")]
        public decimal Ciudad { get; set; }


        [Required(ErrorMessage = "El campo Direccion es obligatorio")]
        public string Direccion { get; set; }


        [Required(ErrorMessage = "El campo Correo es obligatorio")]
        public decimal Correo { get; set; }


        [Required(ErrorMessage = "El campo Usuario es obligatorio")]
        public decimal Username { get; set; }


        [Required(ErrorMessage = "El campo Password es obligatorio")]
        public decimal Password { get; set; }


    }

}
