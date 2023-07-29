using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using gitdeneme.Models.Slider;
using gitdeneme.Models.InfoBox;
using gitdeneme.Models.New;
using gitdeneme.Models.Comment;


namespace gitdeneme.Models.DataContext
{
    public class DataContext : DbContext
    {

        public DataContext() : base("GencYazilimcilarDb")
        {

        }

        public DbSet<SliderInfoes> SliderInfo { get; set; }
        public DbSet<InfoBoxInfoes> InfoBoxInfo { get; set; }
        public DbSet<NewInfoes> NewInfo { get; set; }
        public DbSet<CommentInfoes> CommentInfo { get; set; }
    }


}