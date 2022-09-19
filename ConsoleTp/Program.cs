using MesClass;

Adresse adresse = new(30, "rue Auguste Dupuis", "59133", "Phalempin");

List<Employe> initList()
{
    Employe employe1 = new(1, "Nathan Caron", adresse, 1600, new(2022, 09, 16));
    Employe employe2 = new(2, "Nathan Caron", adresse, 1900, new(2022, 09, 16));
    Employe employe3 = new(3, "Nathan Caron", adresse, 3000, new(2022, 09, 16));
    Employe employe4 = new(4, "Nathan Caron", adresse, 1000, new(2022, 09, 16));
    Employe employe5 = new(5, "Nathan Caron", adresse, 2000, new(2022, 09, 16));

    return new List<Employe>
    {
        employe1,
        employe2,
        employe3,
        employe4,
        employe5,
    };
}

void showEmployes(List<Employe> employes)
{
    employes.ForEach((employe) =>
    {
        Console.WriteLine($"Employé n°{employes.IndexOf(employe) + 1}");
        Console.WriteLine(employe);
        Console.WriteLine("\n");
    });

}

showEmployes(initList());

Employe getEmploye(int id)
{
    List<Employe> employes = initList();
    Employe? findEmploye = employes.Find((employe) => employe.Id == id);

    if (findEmploye != null) return findEmploye;
    else throw new GetEmployeException();
}

void answerEmploye()
{
    try
    {
        Console.Write("ID: ");
        int id = Int32.Parse(Console.ReadLine()!);

        Console.Write("Pourcentage: ");
        int pourcentage = Int32.Parse(Console.ReadLine()!);

        Employe employe = getEmploye(id);
        employe.donnerPromotion(pourcentage);

        Console.WriteLine(employe);
    }
    catch (FormatException)
    {
        Console.WriteLine("Veuillez écire le bon type");
    }
    catch (GetEmployeException e)
    {
        Console.WriteLine(e.Message);
    }
}

answerEmploye();

class GetEmployeException : Exception
{
    public GetEmployeException() : base("L'employé est introuvable") { }
}