﻿using foodies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealProject.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required(ErrorMessage = "Field must be non-empty")]
        public string Content { get; set; }

        public DateTime Date { get; set; }
        public int PostId { get; set; }

       // cu linia asta de mai jos se suprascriu comm si nu se salveaza
       // public int GroupId { get; set; }
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Group group { get; set; }
        public virtual Post Post { get; set; }
    }
}