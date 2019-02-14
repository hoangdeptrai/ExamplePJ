using Example.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Example.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public string Name { set; get; }
        public string Alias { set; get; }
        public int CategoryID { set; get; }
        public string Image { set; get; }
        public string Content { set; get; }
        public string Description { set; get; }
        
        public bool? HomeFlag { set; get; }
        public bool? HotFlaf { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { set; get; }

        [ForeignKey("CategoryID")]
        public virtual IEnumerable<PostTag> PostTags { set; get; }
    }
}