using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI.Cases
{
    public class Cliente
    {
        public int ClientId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
    }

    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cliente);
    }

    public class ClienteRepository : IClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            //Faz algo
            throw new NotImplementedException();
        }
    }

    public interface IClienteServices
    {
        void AdicionarCliente(Cliente cliente);
    }

    public class ClientesService: IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;

        public ClientesService(IClienteRepository clienteRepository)
        {
            this._clienteRepository = clienteRepository;
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _clienteRepository.AdicionarCliente(cliente);
        }
    }
}
