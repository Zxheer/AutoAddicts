using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AutoAddicts.Models
{
    public class Sold
    {
        [ScaffoldColumn(false)]
        public int SoldID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string SoldName { get; set; }

        [Required, StringLength(10000), Display(Name = "Sold Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        public string Warranty { get; set; }

        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        public string CustomerUserName { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}