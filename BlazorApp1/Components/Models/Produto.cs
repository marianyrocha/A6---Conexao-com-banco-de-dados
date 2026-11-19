using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Components.Models;

public class Produto
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "O campo Nome deve ser preenchido")]
    public string Nome { get; set; } = "";
    
    [Range(0.01, 1000000000.00, ErrorMessage = "O preço deve ser maior que R$ 0,00") ]
    [Precision(10, 2)]
    public decimal Preco { get; set; }
 
    [Range(1, 100000, ErrorMessage = "A quantidade deve ser maior que 0") ]
    public int Quantidade { get; set; }
    
}