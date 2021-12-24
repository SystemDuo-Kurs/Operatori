
Neka n1 = new();
Neka n2 = new();
Bla b = new();
n1++;

n1 = 12;
n1 = "asd";

public class Neka
{
    public int Broj;
    public string BlaBla;

    public static Neka operator ++(Neka nPrva)
        => new Neka { Broj = nPrva.Broj++ };
    public static implicit operator Neka(int broj)
        => new Neka { Broj = broj};
    public static implicit operator Neka(string txt)
        => new Neka { BlaBla = txt };
}

public class Bla
{
    public string Name;
}
