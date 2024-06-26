using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class ProductDto
{
    [Required]
    public string ProductName { get; set; }
    [Required]
    public decimal ProductWeight { get; set; }
    [Required]
    public decimal ProductWidth { get; set; }
    [Required]
    public decimal ProductHeight { get; set; }
    [Required]
    public decimal ProductDepth { get; set; }
    [Required]
    public List<int> ProductCategories { get; set; }
}

