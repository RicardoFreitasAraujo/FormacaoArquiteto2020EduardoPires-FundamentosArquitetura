using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03___Behavior._3._1___Command
{
    internal abstract class Commander
    {
        public abstract void Executar();
        public abstract void Desfazer();
    }
}
