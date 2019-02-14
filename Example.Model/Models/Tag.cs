﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Example.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        public string ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        [MaxLength(50)]
        public string Type { set; get; }
    }
}