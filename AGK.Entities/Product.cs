﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGK.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public String Name { get; set; }
        public String Info { get; set; }
    
        public int CategoryID { get; set; }
        public int ManufactureID { get; set; }
        
        public Double Cost { get; set; }
        public int Instock { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }

        [ForeignKey("ManufactureID")]
        public Manufacturer Manufacturer { get; set; }

        public virtual ICollection<Image> Images { get; set; }
        
    }
}
