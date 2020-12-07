using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webproje.Models
{

    public class TelefonVeri
    {
        public int Id { get; set; }
        public string Telefon { get; set; }
        public string Model { get; set; }
        public short Yıl { get; set; }
        public long Fiyat { get; set; }

        public static List<TelefonVeri> VeriListe = new List<TelefonVeri>
    {
        new TelefonVeri
        {
            Id=1,
            Telefon="İphone",
            Model="XS",
            Yıl=2020,
            Fiyat=9800,
        },
        new TelefonVeri
        {
            Id=2,
            Telefon="Huawei",
            Model="Mate 20 Lite",
            Yıl=2018,
            Fiyat=2800,


        },
        new TelefonVeri
        {
            Id=3,
            Telefon="Samsung",
            Model="S10",
            Yıl=2019,
            Fiyat=3500,


        },
        new TelefonVeri
        {
            Id=4,
            Telefon="Xiomi",
            Model="Note 8 Pro",
            Yıl=2020,
            Fiyat=4000,


        },
        new TelefonVeri
        {
            Id=5,
            Telefon="İphone",
            Model="XR",
            Yıl=2020,
            Fiyat=10000,


        },
        new TelefonVeri
        {
            Id=6,
            Telefon="Sony",
            Model="XZ Premium",
            Yıl=2015,
            Fiyat=2500,


        },

    };
    }
}
