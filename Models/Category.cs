using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Informe o titulo")]
    [MinLength(3, ErrorMessage = "A categoria deve ter pelo menos 3 caracteres")]
    [MaxLength(80, ErrorMessage = "A categoria deve ter menos que 80 caracteres")]
    public string Title { get; set; } = string.Empty;
}