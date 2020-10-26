using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlogCore.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre es obligatorio")]
        [Display(Name="Nombre del articulo")]
        public string Name { get; set; }

        [Display(Name = "Fecha de Creación")]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Nombre del articulo")]
        public string UrlImage { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category category { get; set; }

        [Required(ErrorMessage ="La descripción del articulo es nesesaria")]
        [Display(Name="Descripción")]
        public string Description { get; set; }


    }
}
