using MesClass;

namespace TestUnitaire;

public class AdresseTests
{
    // Adresse
    private int numero = 30;
    private string rue = "rue Auguste Dupuis";
    private string codePostal = "59133";
    private string ville = "Phalempin";

    // Employe
    private int id = 10;
    private string nom = "Nathan Caron";
    private double salaire = 1600;
    private DateTime dateArrivee = new DateTime(2022, 09, 10);

    [Test]
    public void TestAccesseurs()
    {
        Adresse adresse = new(this.numero, this.rue, this.codePostal, this.ville);

        Assert.Multiple(() =>
        {
            Assert.That(adresse.Numero, Is.EqualTo(this.numero));
            Assert.That(adresse.Rue, Is.EqualTo(this.rue));
            Assert.That(adresse.CodePostal, Is.EqualTo(this.codePostal));
            Assert.That(adresse.Ville, Is.EqualTo(this.ville));
        });
    }

    [Test]
    public void TestMutateurs()
    {
        Adresse adresse = new(this.numero, this.rue, this.codePostal, this.ville);

        Assert.That(adresse.Ville, Is.EqualTo(this.ville));

        adresse.Ville = "Test";

        Assert.That(adresse.Ville, Is.EqualTo("Test"));
    }

    [Test]
    public void TestMethodPromotion()
    {
        Adresse adresse = new(this.numero, this.rue, this.codePostal, this.ville);
        Employe employe = new(this.id, this.nom, adresse, this.salaire, this.dateArrivee);

        Assert.That(employe.Salaire, Is.EqualTo(this.salaire));

        employe.donnerPromotion(10);

        Assert.That(employe.Salaire, Is.EqualTo(1760));
    }
}
