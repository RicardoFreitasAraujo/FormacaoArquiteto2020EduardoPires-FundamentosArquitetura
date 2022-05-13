using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01___Creational._1._1___Abstract_Factory
{
    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuincho();
        public abstract Veiculo CriarVeiculo(string modelo, Porte porte);
    }
}
