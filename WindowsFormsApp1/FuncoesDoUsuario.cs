namespace WindowsFormsApp1
{
    internal class FuncoesDoUsuario : OpcoesAjuste
    {
        private string _nome;
        public string nome
        {
            get { return this._nome; }

            set
            {
                if (value.Length == 0)
                    throw new System.ArgumentOutOfRangeException("Informe o nome da função!");
                else
                    this._nome = value;
            }
        }

        private char _caracter;
        public char caracter
        {
            get { return this._caracter; }

            set
            {
                if (value.ToString().Trim() == "")
                    throw new System.ArgumentNullException("Informe o caracter para representação do processo de aquecimento!");
                else
                    this._caracter = value;
            }
        }

        public FuncoesDoUsuario() : base (1, 1)
        {
            this.nome = "Nova função";
            this.caracter = '.';
        }

        public FuncoesDoUsuario(OpcoesAjuste ajuste, string nome, char caracter) : base (ajuste.tempo, ajuste.potencia)
        {
            this.nome = nome;
            this.caracter = caracter;
        }
    }
}