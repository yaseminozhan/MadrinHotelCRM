﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadrinHotelCRM.Entities.Models
{
    public class Etiket
    {
        [Key]
        public int EtiketId { get; set; }
        public string EtiketAdi { get; set; }
        public ICollection<MusteriEtiket> MusteriEtiketleri { get; set; }
    }
}
