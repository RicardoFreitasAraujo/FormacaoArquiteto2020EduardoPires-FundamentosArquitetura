using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01___Creational._1._1___Abstract_Factory
{
    public abstract class Veiculo
    {

        protected Veiculo(string modelo, Porte porte)
        {
            this.Modelo = modelo;
            this.Porte = Porte;
        }

        public string Modelo { get; set; }
        public Porte Porte { get; set; }
    }


    public class VeiculoPequeno : Veiculo
    {
        public VeiculoPequeno(string modelo, Porte porte) : base(modelo, porte)
        {

        }
    }

    public class VeiculoMedio : Veiculo
    {
        public VeiculoMedio(string modelo, Porte porte) : base(modelo, porte)
        {

        }
    }

    public class VeiculoGrande : Veiculo
    {
        public VeiculoGrande(string modelo, Porte porte) : base(modelo, porte)
        {

        }
    }

    public class VeiculoCreator
    {
        public static Veiculo Criar(string modelo, Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new VeiculoPequeno(modelo, porte);
                case Porte.Medio:
                    return new VeiculoMedio(modelo, porte);
                case Porte.Grande:
                    return new VeiculoGrande(modelo, porte);
                default:
                    throw new ApplicationException("Porte de Veiculo desconhecido");
            }
        }
    }


}
