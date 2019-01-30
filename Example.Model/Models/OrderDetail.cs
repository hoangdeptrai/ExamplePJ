﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Example.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { set; get; }

        [Key]
        public int ProductID { set; get; }

        public int Quantitty { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Orders { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }
    }
}