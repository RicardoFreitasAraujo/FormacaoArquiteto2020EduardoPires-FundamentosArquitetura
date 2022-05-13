using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01___Creational._1._1___Abstract_Factory
{
    /// <summary>
    /// Client class
    /// </summary>
    public class AutoSocorro
    {

        private readonly Veiculo _veiculo;
        private readonly Guincho _guincho;

        public AutoSocorro(AutoSocorroFactory factory, Veiculo veiculo)
        {
            _veiculo = factory.CriarVeiculo(veiculo.Modelo, veiculo.Porte);
            _guincho = factory.CriarGuincho();
        }

        public void RealizarAtendimento()
        {
            _guincho.Socorrer(_veiculo);
        }

        public static AutoSocorro CriarAutoSocorro(Veiculo veiculo)
        {
            switch (veiculo.Porte)
            {
                case Porte.Pequeno:
                    return new AutoSocorro(new SocorroVeiculoPequenoFactory(), veiculo);
                case Porte.Medio:
                    return new AutoSocorro(new SocorroVeiculoPequenoFactory(), veiculo);
                case Porte.Grande:
                    return new AutoSocorro(new SocorroVeiculoPequenoFactory(), veiculo);
                default:
                    throw new ApplicationException("Não foi possível identificar o veículo");
            }
        }


    }
}
