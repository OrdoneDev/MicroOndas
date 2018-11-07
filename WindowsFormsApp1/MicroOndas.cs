using System.Collections.Generic;

namespace WindowsFormsApp1
{
    internal sealed class MicroOndas
    {
        private static readonly object padlock = new object();
        private static MicroOndas instance = null;

        public List<FuncoesDoUsuario> listFuncoesUsuario;
        public FuncoesDoUsuario funcao;

        private MicroOndas()
        {
            listFuncoesUsuario = new List<FuncoesDoUsuario>
            {
                new FuncoesDoUsuario(new OpcoesAjusteMicroOndas(120, 8), "Arroz", '-'),
                new FuncoesDoUsuario(new OpcoesAjusteMicroOndas(55, 2), "Pipoca", '*'),
                new FuncoesDoUsuario(new OpcoesAjusteMicroOndas(80, 4), "Macarrão", '_'),
                new FuncoesDoUsuario(new OpcoesAjusteMicroOndas(100, 10), "Frango", '!'),
                new FuncoesDoUsuario(new OpcoesAjusteMicroOndas(120, 10), "Bolo", '@')
            };
        }

        public static MicroOndas Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new MicroOndas();
                    }

                    return instance;
                }
            }
        }

        public void CarregarFuncaoUsuario(int indexFuncao)
        {
            funcao = listFuncoesUsuario[indexFuncao];
        }

        public void DefinirFuncao(FuncoesDoUsuario funcao)
        {
            this.funcao = funcao;
        }

        public void DefinirFuncaoRapida()
        {
            OpcoesAjusteMicroOndas ajuste = new OpcoesAjusteMicroOndas(30, 8);

            this.funcao = new FuncoesDoUsuario(ajuste, "rápido", '.');
        }
    }
}