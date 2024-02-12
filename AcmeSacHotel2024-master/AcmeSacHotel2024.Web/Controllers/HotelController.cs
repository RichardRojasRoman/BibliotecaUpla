using AcmeSacHotel2024.Infraestructura.Data;
using Microsoft.AspNetCore.Mvc;

namespace AcmeSacHotel2024.Web.Controllers
{
    public class HotelController : Controller
    {
        private readonly AplicacionDbContexto _contexto;

        public HotelController(AplicacionDbContexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var queryListahotel = _contexto.hotelAcmes.ToList();
            return View(queryListahotel);
        }
    }
}
