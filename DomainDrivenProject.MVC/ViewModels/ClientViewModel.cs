using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace DomainDrivenProject.MVC.ViewModels
{
    public class ClientViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Name")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha o campo Surname")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha com um e-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegistrationDate { get; set; }
        public bool Active { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}