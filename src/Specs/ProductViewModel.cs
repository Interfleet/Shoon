﻿using System;

namespace Specs
{
    public class ProductViewModel
    {
        public Guid AggregateRootId { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}