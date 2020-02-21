using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Tarea4.Models
{
    public class datos
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Apellido { get; set; }
        [Range(15, 100)]
        public int Edad { get; set; }
        public int Teléfono { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
         ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        public int Correo { get; set; }
        public string Género { set; get; }
        public puesto_trabajo trabajo { set; get; }


       
    }

    public enum puesto_trabajo
    {

       puesto1 , puesto2 , puesto3
    }

}