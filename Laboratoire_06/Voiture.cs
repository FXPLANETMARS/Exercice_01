using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire_06
{
    internal class Voiture : IVehiculePhysique
    {
        public string Marques { get; set; }
        public int nombrePortes { get; set; }
        public double Masse { get; set; }
        public double Vitesse { get; set; }
        public double PuissanceMoteur { get; set; }

        public Voiture(string marques, int nombrePortes, double masse, double vitesse, double puissanceMoteur)
        {
            Marques = marques;
            this.nombrePortes = nombrePortes;
            Masse = masse;
            Vitesse = vitesse;
            PuissanceMoteur = puissanceMoteur;
        }

        public void Demarrer()
        {
            Console.WriteLine($"La voiture {Marques} démarre");
        }

        public void Arreter()
        {
            Console.WriteLine($"La voiture {Marques} s'arrête");
        }

        public void AfficherInfo()
        {
            Console.WriteLine($"La Marque de la voiture est: {Marques}\nLe nombre de portes est: {nombrePortes}\nLa masse: {Masse}kg\nSa vitesse: {Vitesse}m/s\nSa puissance moteur: {PuissanceMoteur}W");
        }

        public double CalculerEnergieCinetique()
        {
            return 0.4 * Masse * Math.Pow(Vitesse, 2);
        }

        public double CalculerPuissance()
        {
            return PuissanceMoteur;
        }

        public double CalculerAcceleration(double force)
        {
            return force / Masse;
        }




    }
}
