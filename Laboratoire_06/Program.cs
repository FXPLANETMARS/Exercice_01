namespace Laboratoire_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IVehiculePhysique> list = new List<IVehiculePhysique>();

            Voiture voiture1 = new Voiture("Toyota", 4, 1500, 20, 10000);
            Voiture voiture2 = new Voiture("Mazda", 4, 1200, 25, 15000);
            list.Add(voiture1);//Ajout à la collection
            list.Add(voiture2);


            foreach (var Auto in list)
            {
                Auto.Demarrer();
                Auto.AfficherInfo();
                Console.WriteLine($"L'énergie cinétique: {Auto.CalculerEnergieCinetique()} joules");
                Console.WriteLine($"Puissance Moteur: {Auto.CalculerPuissance()} watts");
                Console.WriteLine($"Acceleration pour une force de 1000N: {Auto.CalculerAcceleration(1000)} m/s^2");
                Auto.Arreter();
                Console.WriteLine("-----------------------");
            }
                Console.ReadKey();
        }
    }
}
