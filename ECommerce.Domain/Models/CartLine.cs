﻿using ECommerce.Domain.Entities;

namespace ECommerce.Domain.Models;

public class CartLine
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
}
