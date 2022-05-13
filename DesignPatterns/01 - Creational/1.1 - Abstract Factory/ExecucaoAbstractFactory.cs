using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01___Creational._1._1___Abstract_Factory
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            var veiculoSocorro = new List<Veiculo>
            {
                VeiculoCreator.Criar("Celta", Porte.Pequeno),
                VeiculoCreator.Criar("Jetta", Porte.Medio),
                VeiculoCreator.Criar("BMW X6", Porte.Grande)
            };

        veiculoSocorro.ForEach(v => AutoSocorro.CriarAutoSocorro (v).RealizarAtendimento());

    }
    }
}
