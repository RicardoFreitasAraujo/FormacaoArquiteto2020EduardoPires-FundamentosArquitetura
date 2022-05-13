using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02___Structural._2._1___Adapter
{
    public class TransacaoService
    {
        private readonly ILogger _logger;

        public TransacaoService(ILogger logger)
        {
            _logger = logger;
        }

        public void RealizarTransacao()
        {
            _logger.Log("Transação realizada");
        }
    }
}
