namespace MesClass;

public class Employe
{
    private int id;
    private string nom;
    private Adresse adresse;
    private double salaire;
    private DateTime dateArrivee;
    private List<Promotion> promotions;

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Nom
    {
        get => nom;
        set => nom = value;
    }

    public Adresse Adresse
    {
        get => adresse;
        set => adresse = value;
    }

    public double Salaire
    {
        get => salaire;
        set => salaire = value;
    }

    public DateTime DateArrivee
    {
        get => dateArrivee;
        set => dateArrivee = value;
    }

    public List<Promotion> Promotions
    {
        get => promotions;
    }

    public Employe(int id, string nom, Adresse adresse, double salaire, DateTime dateArrivee)
    {
        this.id = id;
        this.nom = nom;
        this.adresse = adresse;
        this.salaire = salaire;
        this.dateArrivee = dateArrivee;
    }

    public override string ToString()
    {
        return $"ID: {this.id}\nNom: {this.nom}\nAdresse: {this.adresse}\nSalaire: {this.salaire}\nDate d'arrivée: {this.dateArrivee}";
    }

    public void donnerPromotion(double pourcentage)
    {
        Promotion promotion = new(DateTime.Now, pourcentage, this.salaire);
        this.promotions.Add(promotion);
        this.salaire += (this.salaire * pourcentage / 100);
    }
}
