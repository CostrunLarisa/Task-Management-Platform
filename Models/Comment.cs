using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task_Management_Platform.Models
{
    public class Comment
    {
        [Required]
        public string CommentId { get; set; }
        public string Content { get; set; }

        //foreign key
        //un comntariu este asociat unui task
        public virtual Task Task { get; set; }
    }
}