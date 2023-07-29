using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gitdeneme.Models.New
{
    public class NewInfoes
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Fotoğraf Linki")]
        [StringLength(255, ErrorMessage = "Fotoğraf Linki Alanı 255 Karakterden Fazla Olamaz")]
        public string PictureLink { get; set; }

        [DisplayName("Etiket")]
        [StringLength(255, ErrorMessage = "Etiket Alanı 255 Karakterden Fazla Olamaz")]
        public string Tag { get; set; }

        [DisplayName("Tarih")]
        [StringLength(255, ErrorMessage = "Tarih Alanı 255 Karakterden Fazla Olamaz")]
        public string Date { get; set; }

        [DisplayName("Başlık")]
        [StringLength(255, ErrorMessage = "Başlık Alanı 255 Karakterden Fazla Olamaz")]
        public string Title { get; set; }

        [DisplayName("Açıklama")]
        [StringLength(255, ErrorMessage = "Açıklama Alanı 255 Karakterden Fazla Olamaz")]
        public string Description { get; set; }
    }
}