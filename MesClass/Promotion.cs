namespace MesClass;

public class Promotion
{
    private DateTime datePromotion;
    private double pourcentage;
    private double salaireAvantPromo;

    public DateTime DatePromotion
    {
        get => datePromotion;
        set => datePromotion = value;
    }

    public double Pourcentage
    {
        get => pourcentage;
        set => pourcentage = value;
    }

    public double SalaireAvantPromo
    {
        get => salaireAvantPromo;
        set => salaireAvantPromo = value;
    }

    public Promotion(DateTime datePromotion, double pourcentage, double salaireAvantPromo)
    {
        this.datePromotion = datePromotion;
        this.pourcentage = pourcentage;
        this.salaireAvantPromo = salaireAvantPromo;
    }
}
