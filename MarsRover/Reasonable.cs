using MarsRover.Commandes;
using MarsRover.Utilities;
using System;

//couche anti corruption
namespace MarsRover
{
    public class Reasonable
    {
        private Rover rover = new RoverBuilder()
               .SurUnePlanète(planète => planète.SphériqueDeTailleX(2))
               .Positionné(0, 0)
               .Orienté(Orientation.Est)
               .Build();
        public String AvancerCommande() => "Ma position est: " + rover.Traiter(new AvancerCommande()).Position;
        public String TourneAGaucheCommande() => "Ma position est: " + rover.Traiter(new TourneAGaucheCommande()).Position;
        public String TournerADroiteCommande() => "Ma position est: " + rover.Traiter(new TournerADroiteCommande()).Position;
        public String ErreurCommande(string error) => "Impossible de traiter cette commande: " + error;
    }
}
