﻿using Example.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Example.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }

        public int CategoryID { set; get; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory Products { set; get; }

        public string Image { set; get; }
        public XElement MoreImage { set; get; }
        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int ViewCount { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}