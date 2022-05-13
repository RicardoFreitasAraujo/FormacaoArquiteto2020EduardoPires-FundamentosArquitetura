using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI.Controllers
{
    public class VidaRealController : Controller
    {
        private readonly IClienteServices _clienteServices;

        public VidaRealController(IClienteServices clienteServices)
        {
            this._clienteServices = clienteServices;
        }

        public IActionResult Index()
        {
            _clienteServices.AdicionarCliente(new Cliente());
            return View();
        }
    }
}
