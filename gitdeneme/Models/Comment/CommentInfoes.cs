using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gitdeneme.Models.Comment
{
    public class CommentInfoes
    {

        [Key]
        public int Id { get; set; }

        [DisplayName("İsim")]
        [StringLength(40, ErrorMessage = "İsim Alanı 40 Karakterden Fazla Olamaz.")]
        public string Name { get; set; }

        [DisplayName("Yorum")]
        [StringLength(255, ErrorMessage = "Yorum Alanı 255 Karakterden Fazla Olamaz.")]
        public string Comment { get; set; }
    }
}