using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogCore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Ingresa un nombre para la categoria")]
        public string Name { get; set; }

        [Required(ErrorMessage ="El numero de orden es nesesario")]
        public int Order { get; set; }
    }
}
