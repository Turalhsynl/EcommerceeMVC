﻿using ECommerce.Domain.Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ECommerce.WebUI
{
    public class ProductListViewModel
    {
        public List<Product> Product { get; set; }
        public int PageSize { get; set; }
        public int PageCount { get; set; }
        public int CurrentCategory { get; set; }
        public int CurrentPage { get; set; }
    }
}