using System;
using System.Collections.Generic;

namespace Practica20240312.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
