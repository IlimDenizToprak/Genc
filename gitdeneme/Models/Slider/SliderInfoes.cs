﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gitdeneme.Models.Slider
{
    public class SliderInfoes
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Ana Yazı")]
        [StringLength(255, ErrorMessage = "Ana Yazı 255 Karakterden Fazla Olamaz.")]
        public string MainText { get; set; }

        [DisplayName("Açıklama")]
        [StringLength(255, ErrorMessage = "Açıklama Alanı 255 Karakterden Fazla Olamaz.")]
        public string Description { get; set; }
    }
}