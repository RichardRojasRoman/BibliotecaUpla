using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeSacHotel2024.Dominio.Entidades
{
    public class HotelAcme
    {
        public int HotelAcmeId { get; set; }
        public required string nom_hotel { get; set; }
        public string? des_hotel { get; set; }
        public double pre_hotel { get; set; }
        public int m2_hotel { get; set; }
        public int cap_hotel { get; set; }
        public string? img_hotel { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
