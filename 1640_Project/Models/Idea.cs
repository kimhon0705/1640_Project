﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1640_Project.Models
{
    public class Idea
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdeaID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public int ViewCount { get; set; }
        public int CommentCount { get; set; }
        public int VotesCount { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int CurrentUserVoteType { get; set; }

        public int UserID { get; set; }

        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        [Display(Name = "Deadline")]
        public int SubmissionID { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        [ForeignKey("SubmissionID")]
        public virtual Submission Submission { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Vote> Votes { get; set; }
    }
}