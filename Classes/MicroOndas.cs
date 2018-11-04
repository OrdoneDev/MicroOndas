using System;

public sealed class MicroOndas
{
    private static readonly MicroOndas instance = new MicroOndas();

    public int tempo
    {
        get;

        set
        {
            if ((value < 1) || (value > 120))
                throw new System.ArgumentOutOfRangeException("Informe o tempo para aquecer entre 1s à 2m!");
            else
                this.tempo = value;

        }
    }

    public int potencia
    {
        get;

        set
        {
            if ((value < 1) || (value > 10))
                throw new System.ArgumentOutOfRangeException("Informe a potência entre 1 à 10!");
            else
                this.potencia = value;

        }
    }

    public static MicroOndas Instance
    {
        get
        {
            return instance;
        }
    }

    public MicroOndas()
    {
    }

    public void Aquecer(int _tempo, int _potencia)
    {
        this.tempo = _tempo;
        this.potencia = _potencia;

        //TODO
    }

    public void Aquecer()
    {
        this.tempo = 30;
        this.potencia = 8;
    }
}
