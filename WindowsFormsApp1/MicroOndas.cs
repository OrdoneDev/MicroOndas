using System.Collections.Generic;

namespace WindowsFormsApp1
{
    internal sealed class MicroOndas
    {
        private static readonly object padlock = new object();
        private static MicroOndas instance = null;

        public List<FuncoesDoUsuario> listFuncoesUsuario;
        public OpcoesAjuste ajuste;

        MicroOndas()
        {

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

        public void DefinirAquecimento(OpcoesAjuste ajuste)
        {
            this.ajuste = ajuste;
        }

        public void DefinirAquecimento()
        {
            this.ajuste = new OpcoesAjuste(30, 8);
        }
    }
}