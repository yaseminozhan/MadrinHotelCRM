﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadrinHotelCRM.Entities.Models
{
    public class OdaTarife
    {
        [Key]
        public int OdaId { get; set; }
        public int TarifeId { get; set; }
        public Oda Oda { get; set; }
        public Tarife Tarife { get; set; }
    }

}
