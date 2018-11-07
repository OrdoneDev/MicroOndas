using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    internal class CadastroDeFuncoesDoUsuario
    {
        private static List<FuncoesDoUsuario> listTemp;
        public static List<FuncoesDoUsuario> ListTemp
        {
            get
            {
                if (listTemp == null)
                    listTemp = new List<FuncoesDoUsuario>();
                return listTemp;
            }
        }   

        public static void CarregarFuncoesCadastradas()
        {
            OpcoesAjusteMicroOndas ajuste;
            FuncoesDoUsuario funcao;

            foreach (FuncoesDoUsuario funcaoTemp in MicroOndas.Instance.listFuncoesUsuario)
            {
                ajuste = new OpcoesAjusteMicroOndas(funcaoTemp.tempo, funcaoTemp.potencia);
                funcao = new FuncoesDoUsuario(ajuste, funcaoTemp.nome, funcaoTemp.caracter);

                listTemp.Add(funcao);
            }
        }

        public static List<FuncoesDoUsuario> CarregarArqFuncoes(String caminhoArq)
        {
            System.IO.StreamReader sReader;
            OpcoesAjusteMicroOndas ajuste;
            FuncoesDoUsuario funcao;
            String[] lines;
            string line;

            listTemp = new List<FuncoesDoUsuario>();
            sReader = new System.IO.StreamReader(caminhoArq);

            try
            {
                while ((line = sReader.ReadLine()) != null)
                {
                    lines = line.Split(',');
                    ajuste = new OpcoesAjusteMicroOndas(Convert.ToInt32(lines[2]), Convert.ToInt32(lines[3]));
                    funcao = new FuncoesDoUsuario(ajuste, lines[0], lines[1][0]);

                    listTemp.Add(funcao);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            sReader.Close();

            return listTemp;
        }

        public static void SalvarModificacoes()
        {
            MicroOndas.Instance.listFuncoesUsuario = CadastroDeFuncoesDoUsuario.listTemp;
        }
    }
}