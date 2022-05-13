using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI.Cases
{
    public class OpercacoService
    {
        public OpercacoService(IOperacaoTransient transient, 
            IOperacaoScoped scoped, 
            IOperacaoSingleton singleton, 
            IOperacaoSingletonInstance singletonInstance)
        {
            this.Transient = transient;
            this.Scoped = scoped;
            this.Singleton = singleton;
            this.SingletonInstance = singletonInstance;
        }

        public IOperacaoTransient Transient { get; }
        public IOperacaoScoped Scoped { get; }
        public IOperacaoSingleton Singleton { get; }
        public IOperacaoSingletonInstance SingletonInstance { get; }
    }


    public interface IOperacao
    {
        Guid OperacaoId { get; }
    }

    public interface IOperacaoTransient : IOperacao
    {

    }

    public interface IOperacaoScoped : IOperacao
    {

    }

    public interface IOperacaoSingleton : IOperacao
    {

    }

    public interface IOperacaoSingletonInstance : IOperacao
    {

    }


    public class Operacao : IOperacaoTransient,
                           IOperacaoSingleton,
                           IOperacaoSingletonInstance,
                           IOperacaoScoped
    {

        public Operacao(): this(Guid.NewGuid())
        {

        }

        public Operacao(Guid id)
        {
            OperacaoId = id;
        }

        public Guid OperacaoId { get; private set; }
    }



}
