namespace MesClass;

public class Adresse
{
    private int numero;
    private string rue;
    private string codePostal;
    private string ville;

    public int Numero
    {
        get => numero;
        set => numero = value;
    }

    public string Rue
    {
        get => rue;
        set => rue = value;
    }

    public string CodePostal
    {
        get => codePostal;
        set => codePostal = value;
    }

    public string Ville
    {
        get => ville;
        set => ville = value;
    }

    public Adresse(int numero, string rue, string codePostal, string ville)
    {
        this.numero = numero;
        this.rue = rue;
        this.codePostal = codePostal;
        this.ville = ville;
    }

    public override string ToString()
    {
        return $"{numero} {rue} - {codePostal} - {ville}";
    }
}