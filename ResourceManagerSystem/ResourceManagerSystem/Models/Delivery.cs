﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResourceManagerSystem.Models
{
    public class Delivery
    {
        [Key]
        public int DeliveryID { set; get; }
        [DisplayName("Repp")]
        public int ReppID { set; get; }
        [DisplayName("Lote")]
        public string LotID { set; get; }
        [DisplayName("Cantidad")]
        public int Quantity { set; get; }
        [DisplayName("Description")]
        public string Description { set; get; }
        [DisplayName("Marca")]
        public string Brand { set; get; }

        public Unit Unit { set; get; }

        public REPP Reep { set; get; }
        public Lot Lot { set; get; }
    }
    public enum Unit
    {
        [Display(Name = "Par")]
        Pair,
        [Display(Name = "Unidad")]
        Unity
    }
}
