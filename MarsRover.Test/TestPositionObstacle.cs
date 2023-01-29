using MarsRover.Commandes;
using MarsRover.Test.Utilities;

namespace MarsRover.Test
{
    public class TestPositionObstacle
    {
        [Fact]
        public void TestAvancerBoucleObstacle()
        {
            // ETANT DONNE une planète Sphérique de taille 3
            // ET un rover positionné en 0,0 orienté Sud
            var rover = new RoverBuilder()
                .SurUnePlanète(planète => planète.SphériqueDeTailleX(3).AyantUnObstacle(4, 0))
                .Orienté(Orientation.Sud)
                .Positionné(0, 0)
                .Build();

            // QUAND on lui demande d'avancer
            var positionFinale = rover.Traiter(new AvancerCommande()).Position;

            // ALORS la position renvoyée est de 0,1
            Assert.Equal(new Point(0, -1), positionFinale);
        }
    }
}
