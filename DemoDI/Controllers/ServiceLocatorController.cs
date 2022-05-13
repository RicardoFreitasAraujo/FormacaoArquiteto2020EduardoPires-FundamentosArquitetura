﻿using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI.Controllers
{
    public class ServiceLocatorController : Controller
    {

        private readonly IServiceProvider _serviceProvider;

        public ServiceLocatorController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        
        public void Index()
        {
            //Retornar null se não estiuver registrado
            _serviceProvider.GetRequiredService<IClienteServices>().AdicionarCliente(new Cliente());
        }
    }
}