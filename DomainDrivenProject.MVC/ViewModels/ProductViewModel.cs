using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DomainDrivenProject.MVC.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Name")]
        [MaxLength(250, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Price { get; set; }

        [DisplayName("Disponível?")]
        public bool Available { get; set; }

        public int ClientId { get; set; }
        public virtual ClientViewModel Client { get; set; }
    }
}