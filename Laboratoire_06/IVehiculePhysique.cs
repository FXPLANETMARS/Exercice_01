using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoire_06
{
    internal interface IVehiculePhysique
    {
        void Demarrer();
        void Arreter();
        void AfficherInfo();
        double CalculerEnergieCinetique();
        double CalculerPuissance();
        double CalculerAcceleration(double force);
    }
}
