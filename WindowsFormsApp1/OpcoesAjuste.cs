namespace WindowsFormsApp1
{
    internal class OpcoesAjuste
    {
        private int _tempo;
        public int tempo
        {
            get { return this._tempo; }

            protected set
            {
                if ((value < 1) || (value > 120))
                    throw new System.ArgumentOutOfRangeException("Informe o tempo para aquecer entre 1s à 2m!");
                else
                    this._tempo = value;

            }
        }

        private int _potencia;
        public int potencia
        {
            get { return this._potencia; }

            protected set
            {
                if ((value < 1) || (value > 10))
                    throw new System.ArgumentOutOfRangeException("Informe a potência entre 1 à 10!");
                else
                    this._potencia = value;

            }
        }

        public OpcoesAjuste(int tempo, int potencia)
        {
            this.tempo = tempo;
            this.potencia = potencia;
        }
    }
}