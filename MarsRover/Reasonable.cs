using MarsRover.Commandes;
using MarsRover.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Reasonable
    {
        private Rover rover = new RoverBuilder()
               .SurUnePlanète(planète => planète.ToriqueDeTailleX(4).AyantUnObstacle(0, 3))
               .Positionné(0, 0)
               .Orienté(Orientation.Nord)
               .Build();
        public String AvancerCommande() => "Ma position est: " + rover.Traiter(new AvancerCommande()).Position;
        public String TourneAGaucheCommande() => "Ma position est: " + rover.Traiter(new TourneAGaucheCommande()).Position;
        public String TournerADroiteCommande() => "Ma position est: " + rover.Traiter(new TournerADroiteCommande()).Position;
        public String ErreurCommande(string error) => "Impossible de traiter cette commande: " + error;
    }
}
