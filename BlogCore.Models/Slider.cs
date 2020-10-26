using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogCore.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre del silder es nesesario")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="El estado es requerido")]
        public bool State { get; set; }

        [Required(ErrorMessage ="la imagen es neesaria")]
        [Display(Name ="Directorio de imagen")]
        public string UrlImage { get; set; }

    }
}
