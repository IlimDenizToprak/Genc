using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gitdeneme.Models.InfoBox
{
    public class InfoBoxInfoes
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Başlık")]
        [StringLength(255, ErrorMessage = "Başlık Alanı 255 Karakterden Fazla Olamaz.")]
        public string Title { get; set; }

        [DisplayName("Açıklama")]
        [StringLength(255, ErrorMessage = "Açıklama Alanı 255 Karakterden Fazla Olamaz.")]
        public string Description { get; set; }
    }
}