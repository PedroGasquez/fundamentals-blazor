using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Informe o titulo")]
    [MinLength(3, ErrorMessage = "A categoria deve ter pelo menos 3 caracteres")]
    [MaxLength(80, ErrorMessage = "A categoria deve ter menos que 80 caracteres")]
    public string Title { get; set; } = string.Empty;
    
    public string? Description { get; set; }
    
    [Required(ErrorMessage = "Informe o preco do produto")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }
    
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}