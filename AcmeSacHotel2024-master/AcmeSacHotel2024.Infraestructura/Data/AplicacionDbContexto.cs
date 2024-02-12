using AcmeSacHotel2024.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeSacHotel2024.Infraestructura.Data
{
    public class AplicacionDbContexto : DbContext
    {
        public AplicacionDbContexto(DbContextOptions<AplicacionDbContexto> options) : base(options) { }

        public DbSet<HotelAcme> hotelAcmes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelAcme>().HasData(
                new HotelAcme
                {
                    HotelAcmeId = 1,
                    nom_hotel = "Nombre hotel 1",
                    des_hotel = "Aquí va la descripción breve de los servicios  que brinda el hotel",
                    img_hotel = "https://placehold.co/600x400",
                    cap_hotel = 4,
                    pre_hotel = 150,
                    m2_hotel = 250
                },
                new HotelAcme
                {
                    HotelAcmeId = 2,
                    nom_hotel = "Nombre hotel 2",
                    des_hotel = "Aquí va la descripción breve de los servicios  que brinda el hotel",
                    img_hotel = "https://placehold.co/600x400",
                    cap_hotel = 3,
                    pre_hotel = 50,
                    m2_hotel = 50
                },
                new HotelAcme
                {
                    HotelAcmeId = 3,
                    nom_hotel = "Nombre hotel 3",
                    des_hotel = "Aquí va la descripción breve de los servicios  que brinda el hotel",
                    img_hotel = "https://placehold.co/600x400",
                    cap_hotel = 14,
                    pre_hotel = 450,
                    m2_hotel = 450
                }
            );
        }
    }
}
