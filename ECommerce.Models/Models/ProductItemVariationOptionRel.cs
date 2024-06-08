﻿namespace ECommerce.Models.Models;

public class ProductItemVariationOptionRel
{
    public int ProductItemId { get; set; }
    public ProductItem? ProductItem { get; set; }
    public int VariationOptionId { get; set; }
    public VariationOption? VariationOption { get; set; }
}
