﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MadrinHotelCRM.Entities.Enums;

namespace MadrinHotelCRM.Entities.Models
{
    public class Musteri
    {
        [Key]
        public int MusteriId { get; set; }
        public bool YabanciUyrukluMu { get; set; }
        [MaxLength(20)]
        public string? PasaportNo { get; set; }
        [MaxLength(11)]
        public string? TcNo { get; set; }
        [MaxLength(50)]
        public string Ad { get; set; }
        [MaxLength(50)]
        public string Soyad { get; set; }
        [MaxLength(20)]
        public string TelNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Email { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public string Adres { get; set; }
        public ICollection<MusteriEtiket> MusteriEtiketleri { get; set; }
        public ICollection<MusteriEtkilesim> MusteriEtkilesim { get; set; }
        public ICollection<Rezervasyon> Rezervasyonlar { get; set; }
        public ICollection<GeriBildirim> GeriBildirimler { get; set; }
    }
}