using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Article: EntityBase
    {
        [Required, StringLength(50)]
        public string Title { get; set; }
        [Required, StringLength(5000)]
        public string Content { get; set; }
    }
}